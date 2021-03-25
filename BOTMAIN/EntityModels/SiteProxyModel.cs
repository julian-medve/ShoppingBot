using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace BOTMAIN.EntityModels
{
    [Table(Name = "SiteProxies")]
    public class SiteProxyModel
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

        public int SiteId { get; set; }

        public int ProxyId { get; set; }
        
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("SiteId")]
        public virtual SiteModel Site { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ProxyId")]
        public virtual ProxyModel Proxy { get; set; }

        public void Save()
        {
            if (ID == -1)
                MainFrm.context.SiteProxy.Add(this);
            MainFrm.context.SaveChanges();
        }

        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM SiteProxies");
        }
    }
}
