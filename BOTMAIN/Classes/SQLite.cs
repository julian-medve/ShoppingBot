using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using BOTMAIN.Model;

namespace BOTMAIN.Classes
{
    public class MySQLite
    {
        static public MySQLite DB = new MySQLite();
        
        protected static SQLiteConnection createConnection()
        {
            string path = Application.StartupPath + @"\BotMain.sqlite3";
            var myconn = new SQLiteConnection("Data Source=" + path);
            myconn.Open();
            return myconn;
        }


        //proxy database operations
        
        public void deleteAllProxyItems()
        {
            try
            {
                using (var con = createConnection())
                {
                    const string q = "DELETE FROM ProxyList";
                    var cmd = con.CreateCommand();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }
                using (var con = createConnection())
                {
                    const string q = "DELETE FROM SiteProxyList";
                    var cmd = con.CreateCommand();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void UpdateProxyList(int No, string listname, string proxytype, string proxy_list, bool enabled, bool useCurrentIP)
        {
            try
            {
                using (var con = createConnection())
                {
                    var cmd = con.CreateCommand();
                    const string q = "UPDATE ProxyList SET ListName=:listname, ProxyType=:proxytype, ProxyIdList=:proxy_list, Enabled=:enabled, useCurrentIP=:useCurrentIp WHERE Id = :no;";
                    cmd.CommandText = q;
                    cmd.Parameters.Add(":no", DbType.Int32).Value = No;
                    cmd.Parameters.Add(":listname", DbType.String).Value = listname;
                    cmd.Parameters.Add(":proxytype", DbType.String).Value = proxytype;
                    cmd.Parameters.Add(":proxy_list", DbType.String).Value = proxy_list;
                    cmd.Parameters.Add(":enabled", DbType.Boolean).Value = enabled;
                    cmd.Parameters.Add(":useCurrentIp", DbType.Boolean).Value = useCurrentIP;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public int SaveProxyList(int currentId, string listname, string proxytype, string proxy_list, bool enabled, bool useCurrentIP)
        {
            try
            {
                using (var con = createConnection())
                {
                    var cmd = con.CreateCommand();
                    const string q = "INSERT INTO ProxyList(Id, ListName,ProxyType, ProxyIdList, Enabled, useCurrentIP) VALUES(:id, :listname, :proxytype, :proxy_list, :enabled, :useCurrentIp);SELECT last_insert_rowid()";
                    cmd.CommandText = q;
                    cmd.Parameters.Add(":id", DbType.Int32).Value = currentId;
                    cmd.Parameters.Add(":listname", DbType.String).Value = listname;
                    cmd.Parameters.Add(":proxytype", DbType.String).Value = proxytype;
                    cmd.Parameters.Add(":proxy_list", DbType.String).Value = proxy_list;
                    cmd.Parameters.Add(":enabled", DbType.Boolean).Value = enabled;
                    cmd.Parameters.Add(":useCurrentIp", DbType.Boolean).Value = useCurrentIP;
                    var id = cmd.ExecuteScalar();
                    int insertedId = Convert.ToInt32(id);
                    return insertedId;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return -1;
        }

        public int SaveProxyIP(string address, List<string> allProxies)
        {
            if (allProxies == null)
            {
                throw new ArgumentNullException(nameof(allProxies));
            }

            try { 
                if(allProxies.Count == 0)
                {
                    using (var con = createConnection())
                    {
                        var cmd = con.CreateCommand();
                        const string q = "INSERT INTO Proxies(ProxyIP,Status) VALUES(:proxyip, :status);SELECT last_insert_rowid()";
                        cmd.CommandText = q;
                        cmd.Parameters.Add(":proxyip", DbType.String).Value = address;
                        cmd.Parameters.Add(":status", DbType.Int32).Value = 0;
                        var id = cmd.ExecuteScalar();
                        int insertedId = Convert.ToInt32(id);
                        return insertedId;
                    }
                }
                else
                {
                    if(allProxies.Contains(address))
                    {
                        using (var con = createConnection())
                        {
                            var cmd = con.CreateCommand();
                            const string q = "SELECT Id FROM Proxies WHERE ProxyIP = :proxyip";
                            cmd.CommandText = q;
                            cmd.Parameters.Add(":proxyip", DbType.String).Value = address;
                            var id = cmd.ExecuteScalar();
                            int currentId = Convert.ToInt32(id);
                            return currentId;
                        }
                    }
                    else
                    {
                        using (var con = createConnection())
                        {
                            var cmd = con.CreateCommand();
                            const string q = "INSERT INTO Proxies(ProxyIP,Status) VALUES(:proxyip, :status);SELECT last_insert_rowid()";
                            cmd.CommandText = q;
                            cmd.Parameters.Add(":proxyip", DbType.String).Value = address;
                            cmd.Parameters.Add(":status", DbType.Int32).Value = 0;
                            var id = cmd.ExecuteScalar();
                            int insertedId = Convert.ToInt32(id);
                            return insertedId;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return -1;
        }
        public List<string> getAllProxies()
        {
            List<string> list = new List<string>();

            using (SQLiteConnection con = createConnection())
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Proxies order by Id asc";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    list.Add(sqlite_datareader["ProxyIP"].ToString());
                }

            }

            return list;
        }
        
    }
}
