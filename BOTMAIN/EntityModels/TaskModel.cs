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
    [Table(Name = "ShippingTasks")]
    public class TaskModel
    {
        public static Dictionary<string, TaskModel> All = new Dictionary<string, TaskModel>();

        private int id = -1;

        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int ID {
            get {
                return Convert.ToInt32(id);
            }
            set {
                id = value;
                var key = Convert.ToString(id);
                if (!All.Keys.Contains(key))
                {
                    All.Add(key, this);
                }
            }
        }
        public int BillingId { get; set; }
        public int SiteId { get; set; }

        public string LinkType { get; set; }
        public string LinkURL { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Size { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int ShippingRate { get; set; }
        public bool Captcha { get; set; }
        public string Mode { get; set; }
        public bool Guest { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("SiteId")]
        public virtual SiteModel Site { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("BillingId")]
        public virtual BillingModel Billing { get; set; }


        public Task_Rows taskRow;
        public ShopifyTask task;


        public void start()
        {
            taskRow.setStatus("Starting");
            if (task == null)
            {
                task = new ShopifyTask(this);
            }
            task.run();
        }
        public void Stop()
        {
            taskRow.setStatus("Ready");
            task.stop();
        }

        public void Save()
        {
            if(ID == -1)
                MainFrm.context.ShippingTask.Add(this);
            MainFrm.context.SaveChanges();
        }

        public void Delete()
        {
            MainFrm.context.ShippingTask.Remove(this);
            MainFrm.context.SaveChanges();
        }

        public void SetSiteName(string siteName)
        {
            var site = MainFrm.context.Site.Where(_site => _site.SiteName == siteName).FirstOrDefault();
            if (site == null)
            {
                site = new SiteModel();
                site.SiteName = siteName;
                site.Save();
            }

            SiteId = site.ID;
        }
        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM ShippingTasks");
        }
    }

}
