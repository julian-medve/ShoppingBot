using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using BOTMAIN.Model;

namespace BOTMAIN.EntityModels
{
    [Table(Name = "Sites")]
    public class SiteModel
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
        public string SiteName { get; set; }
        public string SiteHost { get; set; }
        
        virtual public ProxyList ProxyList
        {
            get
            {
                return ProxyList.GetProxyList(ID);
            }
        }

        public void Save()
        {
            if(ID == -1)
                MainFrm.context.Site.Add(this);
            MainFrm.context.SaveChanges();
        }
        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM Sites");
        }
    }
}
