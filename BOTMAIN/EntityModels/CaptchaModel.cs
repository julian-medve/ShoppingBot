using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace BOTMAIN.EntityModels
{

    [Table(Name = "Captcha")]
    public class CaptchaModel
    {
        private int id = -1;

        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id
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

        public string gmail { get; set; }

        public string password { get; set; }
        public bool enabled { get; set; }

        public void Save()
        {
            if (Id == -1)
                MainFrm.context.Captcha.Add(this);
            MainFrm.context.SaveChanges();
        }

        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM Captcha");
        }
        public void Delete()
        {
            MainFrm.context.Captcha.Remove(this);
            MainFrm.context.SaveChanges();
        }

    }
}
