using BOTMAIN.Classes;
using BOTMAIN.EntityModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOTMAIN.Model
{
    public class ProxyListItem
    {
        
        public string listname { get; set; }
        public string proxytype { get; set; }
        public List<string> proxyaddresses { get; set; }
        public bool enabled { get; set; }
        public bool useCurrentIP { get; set; }

        public List<int> proxyIds { get; set; }
        public int proxyListId { get; set; }

        private string id_seperator = ",";

        public ProxyListItem()
        {
            proxyaddresses = new List<string>();
        }
        
        public void update(int id)
        {
            this.proxyIds = saveProxies();
            updateProxyList(id);
            //updateSiteProxyList();
        }

        private void updateProxyList(int id)
        {
            string proxy_list = string.Join(id_seperator, proxyIds.Select(proxy => proxy.ToString()).ToArray());
            MySQLite.DB.UpdateProxyList(id,listname, proxytype, proxy_list, enabled, useCurrentIP);
        }
        
        public void save(int currentId)
        {
            this.proxyIds = saveProxies();
            saveProxyList(currentId);
            //saveSiteProxyList(); 
        }
        private List<int> saveProxies()
        {
            var ids = new List<int>();
            foreach (string address in proxyaddresses)
            {
                int id = 0;
                List<string> allProxies = MySQLite.DB.getAllProxies();
                id = MySQLite.DB.SaveProxyIP(address, allProxies);
                ids.Add(id);
            }
            return ids;
        }
        private int saveProxyList(int currentId)
        {
            string proxy_list = string.Join(id_seperator, proxyIds.Select(proxy => proxy.ToString()).ToArray());
            proxyListId = MySQLite.DB.SaveProxyList(currentId, listname,proxytype, proxy_list, enabled, useCurrentIP);
            return proxyListId;
        }

    };

    public class CaptchaItem
    {
        public string GmailAddress { get; set; }
        public string ProxyAddress { get; set; }

        public string GmailPassword { get; set; }

        public bool Enabled { get; set; }
    }
    public class BillingItem
    {
        //Billing Info
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillStateXX { get; set; }
        public string BillZipCode { get; set; }
        public string BillCountry { get; set; }
        public string BillHouseNum { get; set; }
        public string BillPhone { get; set; }
        //Ship Info
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipStateXX { get; set; }
        public string ShipZipCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipHouseNum { get; set; }
        public string ShipPhone { get; set; }
        //Card INfo
        public string FriendlyName { get; set; }
        public string CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public string SecurityCode { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

    };


    public class Proxy
    {
        public static string validate(string proxyString)
        {
            return proxyString;
            //return null;
        }
    }
    
}
