using Newtonsoft.Json.Linq;
using Quobject.EngineIoClientDotNet.Client;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Linq;
using Socket = Quobject.SocketIoClientDotNet.Client.Socket;


namespace TCom
{
    public class WebSocketManager
    {
        public static string WebSocketURL = ConfigurationManager.AppSettings["WebSocketURL"];
        public static Socket webSocket;
        public static bool IsConnected = false;
        public static int IsSentBugsnagMsg = 0;
        public static int IsSentBugsnagMsgCaseCount = 0;
        public static int isSentBugsnagMsgDowntimeData = 0;
        public static int MaxOfflineTime = 1 * 60 * 1000;
        public static bool IsReconnected = false;
        private static bool IsReconnecting = false;
        public static void Initialize(bool refresh = false)
        {
            webSocket = IO.Socket(WebSocketURL, new IO.Options { AutoConnect = false, Reconnection = true, Timeout = -1 });
            webSocket.On(Socket.EVENT_CONNECT, () =>
            {
                IsConnected = true;
                Session.MainForm.SetConnectionStatus(true);
                if (Session.Nodes == null || !Session.Nodes.Any())
                {
                    Session.MainForm.Relog();
                }
                else
                {
                    //Session.syncLocalDowntimes();
                    //Session.syncLocalCounters();
                    Session.syncPieceCounters();
                    Session.resendFailedDowntimeEvents();
                    Session.resendFailedCaseCounts();
                }
            });

            webSocket.On(Socket.EVENT_ERROR, (err) =>
            {
                var exception = (EngineIOException)err;
                Session.log("Error in WS: " + exception.code + " (" + exception.Message + ")");
            });

            webSocket.On(Socket.EVENT_DISCONNECT, () =>
            {
                IsConnected = false;
                Session.MainForm.SetConnectionStatus(false);
            });

            webSocket.On("GetVersion", (cb) =>
            {
                var newVersion = new Version(cb.ToString());
                var oldVersion = new Version(Global.Version);
                if(newVersion.CompareTo(oldVersion) > 0)
                {
                    Session.MainForm.autoUpdater.CheckLatestVersion();
                }
            });

            webSocket.On("GetConnectedLinesData", (cb) =>
            {
                var iack = (IAck)cb;
                var dt = (DataTable)Session.lineGridView.DataSource;
                iack.Call(JArray.FromObject(dt));
            });

            webSocket.On(Socket.EVENT_CONNECT_TIMEOUT, () =>
            {
                Session.consoleLog("connection timeout");
            });

            webSocket.Connect();

            if (!refresh)
            {
                var timer = new MyTimer(10000);
                timer.AddAction(() =>
                {
                    timer.Dispose();
                    if (!IsConnected)
                        Session.MainForm.Resync();
                });
                timer.Start();
            }

        }

        public static void Request(string eventName, object data = null)
        {
            if (IsConnected)
            {
                object jObj = GetJsonObject(data);
                webSocket.Emit(eventName, jObj);
            }
        }

        public static void Request(string eventName, IAck ack, object data = null)
        {
            if (IsConnected)
            {
                object jObj = GetJsonObject(data);
                webSocket.Emit(eventName, ack, jObj);
            }
        }

        private static object GetJsonObject(object data)
        {
            object jObj = null;
            if (data != null)
            {
                Type valueType = data.GetType();
                if (valueType.IsArray)
                {
                    jObj = JArray.FromObject(data);
                }
                else
                {
                    jObj = JObject.FromObject(data);
                }
            }
            return jObj;
        }

        public static void reconnect()
        {
            if (IsReconnecting) return;
            IsReconnecting = true;
            webSocket.Close();
            IsConnected = false;
            Initialize(true);
            IsReconnected = true;
            IsReconnecting = false;
        }
    }
}