using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace BOTMAIN.EntityModels
{
    [Table(Name = "proxies")]
    public class ProxyModel
    {
        private int id = -1;

        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string _ProxyIP { get; set; }
        public string ProxyIP {
            get
            {
                return _ProxyIP;
            }
            set
            {
                _ProxyIP = value;
                list = ProxyIP.Split(':');
            }
        }
        public bool Status { get; set; }

        private string[] list { get; set; }

        public string Host
        {
            get
            {
                return list.Length > 0 ? list[0] : null;
            }
        }
        public int Port
        {
            get
            {
                return list.Length > 1 ? Convert.ToInt32(list[1]) : 0;
            }
        }
        public string Username
        {
            get
            {
                return list.Length > 2 ? list[2] : null;
            }
        }
        public string Password
        {
            get
            {
                return list.Length > 3 ? list[3] : null;
            }
        }

        public void Save()
        {
            if (ID == -1)
                MainFrm.context.Proxy.Add(this);
            MainFrm.context.SaveChanges();
        }
        
        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM proxies");
        }
        public void Delete()
        {
            MainFrm.context.Proxy.Remove(this);
            MainFrm.context.SaveChanges();
        }

    }
}
