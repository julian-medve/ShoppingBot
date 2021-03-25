using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.Classes;
using Bunifu.Json.Linq;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class ProxyTestFrm : Form
    {

        IntPtr ptr = new IntPtr();
        List<ProxyModel> allProxies = null;
        public ProxyTestFrm()
        {
            InitializeComponent();
            allProxies = MainFrm.context.Proxy.ToList();
        }

        public ProxyTestFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        private void ProxyTestFrm_Load(object sender, EventArgs e)
        {
            string id_seperator = "\r\n";
            //this.ProxiesText.Text = "";
            allProxies = MainFrm.context.Proxy.ToList();
            //this.ProxiesText.Text = "kith.com";
            //this.ProxiesText.ReadOnly = true;
            this.resultDataGridView.Focus();
            //this.ProxiesText.Text = string.Join(id_seperator, allProxies.Select(i => i.ProxyIP.ToString()).ToArray());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)resultDataGridView[e.ColumnIndex, e.RowIndex];
                if (Convert.ToBoolean(cbx.EditedFormattedValue))
                {
                    Console.WriteLine(this.resultDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (this.resultDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() != "success")
                    {
                        MessageBox.Show("Please check row exactly. You can\'t check for fail.", "Result");
                        return;
                    }
                }
                this.resultDataGridView.NotifyCurrentCellDirty(true);
            }

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // get proxyIPs from datagrid view.
            Dictionary<string, int> allGridIPs = new Dictionary<string, int>();
            foreach (DataGridViewRow row in this.resultDataGridView.Rows)
            {
                allGridIPs.Add(row.Cells["ProxyAddress"].Value.ToString(), row.Index);
            }

            foreach (ProxyModel item in allProxies)
            {
                string sep = ":";
                string proxyIP = "";
                int proxyPort = 0;
                string userName = "";
                string password = "";
                bool hasAuth = false;
                if (item.ProxyIP.Contains(sep))
                {
                    string[] one_address = SupplyUI.GetPartList(item.ProxyIP);
                    if (one_address.Length == 2)
                    {
                        Console.WriteLine("no authentication.");
                        hasAuth = false;
                        proxyIP = one_address.First();
                        proxyPort = Int32.Parse(one_address.Last());
                    }
                    else
                    {
                        Console.WriteLine("authentication");
                        hasAuth = true;
                        proxyIP = one_address[0];
                        proxyPort = Int32.Parse(one_address[1]);
                        userName = one_address[2];
                        password = one_address[3];
                    }
                }
                else
                {
                    continue;
                }
                try
                {
                    String json;
                    {
                        var req = (HttpWebRequest)HttpWebRequest.Create("http://ip-api.com/json");
                        WebProxy myProxy = new WebProxy(proxyIP, proxyPort);
                        if (hasAuth)
                        {
                            myProxy.Credentials = new NetworkCredential(userName, password);
                        }
                        req.Proxy = myProxy;
                        WebResponse resp = req.GetResponse();
                        json = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                    }
                    var myIp = (string)JObject.Parse(json)["query"];
                    var myCountry = (string)JObject.Parse(json)["countryCode"];
                    myCountry = myCountry + "/";
                    var myCity = (string)JObject.Parse(json)["city"];
                    myCountry = string.Concat(myCountry, myCity);
                    var status = (string)JObject.Parse(json)["status"];

                    //get response time to kith.com                   
                    {
                        var consume = (HttpWebRequest)HttpWebRequest.Create("https://kith.com/");
                        consume.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36";

                        WebProxy myProxy = new WebProxy(proxyIP, proxyPort);
                        if (hasAuth)
                        {
                            myProxy.Credentials = new NetworkCredential(userName, password);
                        }
                        consume.Proxy = myProxy;
                        WebResponse resCon;
                        DateTime start = DateTime.Now;
                        resCon = consume.GetResponse();
                        DateTime end = DateTime.Now;
                        var pingTime = Math.Round((end - start).TotalMilliseconds).ToString();
                        var strAddress = proxyIP + ":" + proxyPort;
                        if (proxyIP == myIp)
                        {
                            Console.WriteLine(strAddress);
                            if (allGridIPs.ContainsKey(strAddress))
                            {
                                var index = allGridIPs[strAddress];
                                this.resultDataGridView.Rows[index].Cells[0].Value = strAddress;
                                this.resultDataGridView.Rows[index].Cells[1].Value = pingTime;
                                this.resultDataGridView.Rows[index].Cells[2].Value = status;
                                this.resultDataGridView.Rows[index].Cells[3].Value = myCountry;
                                this.resultDataGridView.Rows[index].Cells[4].Value = false;
                            }
                            else
                            {
                                this.resultDataGridView.Rows.Add(strAddress, pingTime, status, myCountry);
                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    var httpWebResponse = (HttpWebResponse)ex.Response;
                    string errorText = "";
                    if (httpWebResponse != null)
                    {
                        //HttpStatusCode statusCode = httpWebResponse.StatusCode;
                        //if (statusCode == (HttpStatusCode)403)
                        //{
                        //    using (Stream receiveStream = httpWebResponse.GetResponseStream())
                        //    {
                        //        using (StreamReader streamReader = new StreamReader(receiveStream, Encoding.UTF8))
                        //        {
                        //            Console.WriteLine("herehereherehere");
                        //            Console.WriteLine(streamReader.ReadToEnd());
                        //        }
                        //    }
                        //}
                        if (ex.Status == WebExceptionStatus.ProtocolError)
                        {
                            HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
                            Console.WriteLine((int)httpResponse.StatusCode + " - "
                               + httpResponse.StatusCode);
                            errorText = httpResponse.StatusCode.ToString();

                        }
                    }
                    else
                    {
                        errorText = ex.Status.ToString();
                    }

                    string strErrAddress = proxyIP + ":" + proxyPort;
                    if (allGridIPs.ContainsKey(strErrAddress))
                    {
                        var index = allGridIPs[strErrAddress];
                        this.resultDataGridView.Rows[index].Cells[0].Value = strErrAddress;
                        this.resultDataGridView.Rows[index].Cells[1].Value = "unknown";
                        this.resultDataGridView.Rows[index].Cells[2].Value = errorText;
                        this.resultDataGridView.Rows[index].Cells[3].Value = "unknown";
                        this.resultDataGridView.Rows[index].Cells[4].Value = false;
                    }
                    else
                    {
                        this.resultDataGridView.Rows.Add(strErrAddress, "unknown", errorText, "unknown");
                    }
                }
            }

            foreach (DataGridViewRow row in this.resultDataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == "success")
                {
                    row.ReadOnly = false;
                }
                else
                {
                    row.ReadOnly = true;
                }
            }
        }

        private void saveProxyStatus_Click(object sender, EventArgs e)
        {
            foreach (ProxyModel item in allProxies)
            {
                // set all status into false
                item.Status = false;
                item.Save();
            }

            var selectedSiteId = 1;
            // get the checked row(proxyAddresses) from Datagridview
            List<int> infos = new List<int>();
            int checkedCount = 0;
            foreach (DataGridViewRow row in this.resultDataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == "success")
                {
                    ProxyModel prxModel = allProxies[row.Index];
                    prxModel.Status = true;
                    prxModel.Save();
                }

                if (Convert.ToBoolean(row.Cells[4].Value) && row.Cells["Status"].Value.ToString() == "success")
                {

                    infos.Add(MainFrm.context.Proxy.ToList().ElementAt(row.Index).ID);
                    checkedCount++;
                }
            }
            Console.WriteLine(infos);
            if (checkedCount == 0)
            {
                MessageBox.Show("Please check row exactly.");
            }
            else
            {
                MainFrm.context.Database.ExecuteSqlCommand($"DELETE FROM SiteProxies WHERE SiteId == {selectedSiteId}");

                infos.ForEach(proxyID =>
                {
                    SiteProxyModel siteProxyModel = new SiteProxyModel();
                    siteProxyModel.SiteId = selectedSiteId;
                    siteProxyModel.ProxyId = proxyID;
                    siteProxyModel.Save();

                    //ProxyModel proxyModel = MainFrm.context.Proxy.Where(item => item.ID == proxyID).FirstOrDefault();
                    //proxyModel.ID = proxyID;
                    //proxyModel.Status = true;
                    //proxyModel.Save();
                });
            }
        }
    }
}
