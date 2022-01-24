using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class AdminUser : Users
    {
        public AdminUser() : base() => UserType = "admin";

        private static MySQL mySQL = Configuration.MySQL;

        public async Task<bool> RegisterAsync(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.MySQL)
                return MySQL_Register();
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return await Functions_Register();

            return false;

        }

        private async Task<bool> Functions_Register()
        {
            try
            {
                return (bool)await Functions.PostSingleDataRequest("SetUser", this);
            }
            catch { throw new Exception($"Functions error"); };
        }

        private bool MySQL_Register()
        {
            mySQL.Procedure("register_admin");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            return mySQL.ProceduteExecute();
        }


        public static DataTable GetAllCampaigns()
        {
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "Hashtag", "Webpage", "Creator" })
                dataTable.Columns.Add(culmn);
            mySQL.Quary("SELECT hashtag,webpage,non_profit_user_name FROM campaigns");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read())
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("Hashtag", "hashtag"), ("Webpage", "webpage"), ("Creator", "non_profit_user_name") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "Name", "UserName", "Type" })
                dataTable.Columns.Add(culmn);
            mySQL.Quary("SELECT name,user_name,user_type FROM users");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read())
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("Name", "name"), ("UserName", "user_name"), ("Type", "user_type") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

        public static DataTable GetAllTweets()
        {
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "Hashtag", "UserName" })
                dataTable.Columns.Add(culmn);
            mySQL.Quary("SELECT campaign_hashtag,activist_user_name FROM tweets");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read())
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("Hashtag", "campaign_hashtag"), ("UserName", "activist_user_name") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }
    }
}
