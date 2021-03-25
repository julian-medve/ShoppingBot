using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BOTMAIN.Classes
{
    class SupplyUI
    {
        public SupplyUI()
        {

        }
        public static string GetLocalIPAddress()
        {
            var endPoint = "https://api.ipify.org";
            var request = (HttpWebRequest)WebRequest.Create(endPoint);
            var response = request.GetResponse();
            var resStream = response.GetResponseStream();
            var streamReader = new StreamReader(resStream);
            return streamReader.ReadToEnd();
        }
        public static string[] GetAddressList(string addresses)
        {
            string[] separator = { ",", " ", "\r\n", "\r", "\n\r" };
            string[] strList = addresses.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return strList;
        }

        public static string[] GetPartList(string address)
        {
            string[] separator = { ",", ":", "", "\r\n" };
            string[] strList = address.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return strList;
        }
    }
}
