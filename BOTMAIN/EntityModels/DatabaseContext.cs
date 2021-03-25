using System.Data.Entity;
using SQLite.CodeFirst;

namespace BOTMAIN.EntityModels
{
    public class DatabaseContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteModel>().ToTable("Sites");
            modelBuilder.Entity<ProxyModel>().ToTable("proxies");
            modelBuilder.Entity<SiteProxyModel>().ToTable("SiteProxies");
            modelBuilder.Entity<TaskModel>().ToTable("ShippingTasks");
            modelBuilder.Entity<BillingModel>().ToTable("Profile");
            modelBuilder.Entity<CaptchaModel>().ToTable("Captcha");
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<DatabaseContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<SiteModel> Site { get; set; }
        public DbSet<SiteProxyModel> SiteProxy { get; set; }
        public DbSet<ProxyModel> Proxy { get; set; }
        public DbSet<TaskModel> ShippingTask { get; set; }
        public DbSet<BillingModel> Billing { get; set; }
        public DbSet<CaptchaModel> Captcha { get; set; }
    }
}
