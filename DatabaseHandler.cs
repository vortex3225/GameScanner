using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameScanner
{
    public static class DatabaseHandler
    {
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ToString();
        }


        public static object ?CheckIfNameAlreadyExists(string name_to_check)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.ExecuteScalar("SELECT * FROM sites WHERE name=@Name LIMIT 1", new {Name = name_to_check});
                
            }
        }

        public static void SaveSite(string name, string url, string search_query)
        {
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO sites (name, url, search_query_string) VALUES (@Name, @Url, @QueryString)", new { Name = name, Url = url, QueryString = search_query });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteSite(string name)
        {
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("DELETE FROM sites WHERE name=@Name", new { Name = name});
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<SiteObject> GetSites()
        {
            try
            {
                using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    return cnn.Query<SiteObject>("SELECT * FROM sites").ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<SiteObject>();
            }
        }
    }
}
