using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace BOTMAIN.EntityModels
{
    public class BillingModel
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
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillStateXX { get; set; }
        public string BillZipCode { get; set; }
        public string BillCountry { get; set; }
        //public string BillHouseNum { get; set; }
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
        //public string ShipHouseNum { get; set; }
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

        public void Save()
        {
            if (ID == -1)
                MainFrm.context.Billing.Add(this);
            MainFrm.context.SaveChanges();
        }

        public void Delete()
        {
            MainFrm.context.Billing.Remove(this);
            MainFrm.context.SaveChanges();
        }
        public static void DeleteAll()
        {
            MainFrm.context.Database.ExecuteSqlCommand("DELETE FROM Profile");
        }
    }
}

