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


        public static List<Campaign> MySQL_GetAllCampaigns_List()
        {
            mySQL.Quary("SELECT hashtag,webpage,non_profit_user_name FROM campaigns");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            List<Campaign> campaignsList = new List<Campaign>();
            while (results != null && results.Read())
            {
                try
                {
                    Campaign campaign = new Campaign();
                    campaign.Hashtag = results.GetString("hashtag");
                    campaign.Url = results.GetString("webpage");
                    campaign.NonProfitUser.UserName = results.GetValue("non_profit_user_name").ToString();
                    campaignsList.Add(campaign);
                }
                catch { };
            }
            return campaignsList;
        }

        public static DataTable GetAllCampaigns_DataTable()
        {
            DataTable dataTable = new DataTable();
            List<Campaign> campaignsList = MySQL_GetAllCampaigns_List();
            foreach (string culmn in new[] { "Hashtag", "Webpage", "Creator" })
                dataTable.Columns.Add(culmn);
            foreach (Campaign campaign in campaignsList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Hashtag"] = campaign.Hashtag;
                    dataRow["Webpage"] = campaign.Url;
                    dataRow["Creator"] = campaign.NonProfitUser.UserName;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }


        public static List<Users> MySQL_GetAllUsers_List()
        {
            mySQL.Quary("SELECT name,user_name,user_type FROM users");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            List<Users> userList = new List<Users>();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    Users user = new Users();
                    user.Name = results.GetString("name");
                    user.UserName = results.GetString("user_name");
                    user.UserType = results.GetString("user_type");
                    userList.Add(user);
                }
                catch { };
            }
            return userList;
        }

        public static DataTable GetAllUsers_DataTable()
        {
            DataTable dataTable = new DataTable();
            List<Users> userList = MySQL_GetAllUsers_List();
            foreach (string culmn in new[] { "Name", "UserName", "Type" })
                dataTable.Columns.Add(culmn);
            foreach (Users user in userList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Name"] = user.Name;
                    dataRow["UserName"] = user.UserName;
                    dataRow["Type"] = user.UserType;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }


        public static List<Tweet> MySQL_GetAllTweets_List()
        {
            List<Tweet> tweetList = new List<Tweet>();
            mySQL.Quary("SELECT campaign_hashtag,activist_user_name FROM tweets");
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    Tweet tweet = new Tweet();
                    tweet.Campaign.Hashtag = results.GetString("campaign_hashtag");
                    tweet.ActivistUser.UserName = results.GetString("activist_user_name");
                    tweetList.Add(tweet);
                }
                catch { };
            }
            return tweetList;
        }

        public static DataTable GetAllTweets_DataTable()
        {

            DataTable dataTable = new DataTable();
            List<Tweet> tweetList = MySQL_GetAllTweets_List();
            foreach (string culmn in new[] { "Hashtag", "UserName" })
                dataTable.Columns.Add(culmn);
            foreach (Tweet tweet in tweetList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnHashtag"] = tweet.Campaign.Hashtag;
                    dataRow["clmnWebpage"] = tweet.ActivistUser.UserName;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

    }
}
