using BOTMAIN.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTMAIN.Model
{
    public class ProxyList
    {
        private static Dictionary<int, ProxyList> siteProxyList { get; set; }

        public static ProxyList GetProxyList(int SiteId)
        {
            if (siteProxyList == null)
            {
                getProxyListBySite();
            }
            if (siteProxyList.Keys.Contains(SiteId))
            {
                return siteProxyList[SiteId];
            }
            return new ProxyList();
        }


        private List<ProxyModel> list { get; set; }
        private int point { get; set; }

        public ProxyList(List<ProxyModel> list = null)
        {
            if (list == null) list = new List<ProxyModel>();

            this.list = list;
            point = -1;
        }

        public ProxyModel next()
        {
            if (list.Count == 0) return null;
            point++;
            point = point % list.Count;
            return list[point];
        }

        public void Add(ProxyModel proxy)
        {
            list.Add(proxy);
        }

        public void remove(ProxyModel proxy)
        {
            list.Remove(proxy);
            if (point == list.Count) point--;
        }


        private static Dictionary<int, ProxyList> getProxyListBySite()
        {
            siteProxyList = new Dictionary<int, ProxyList>();
            MainFrm.context.SiteProxy.ToList().ForEach(proxyModel =>
            {
                var key = proxyModel.Site.ID;
                if (!siteProxyList.Keys.Contains(key))
                {
                    siteProxyList.Add(key, new ProxyList());
                }
                siteProxyList[key].Add(proxyModel.Proxy);
            });
            return siteProxyList;
        }
    }

}
