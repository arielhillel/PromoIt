using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Tweet
    {
        public Tweet()
        {
            Campaign = new Campaign();
            ActivistUser = new ActivistUser();
        }

        public string Id { get; set; }
        public Campaign Campaign { get; set; }
        public Users ActivistUser { get; set; }
        public decimal Cash { get; set; }
        public int Retweets { get; set; }
        public bool IsApproved { get; set; }

        private static MySQL mySQL = Configuration.MySQL;



        public void SetTweetCash() 
        {
            mySQL.Procedure("add_tweet");
            mySQL.ProcedureParameter("_tweeter_id", Id);
            mySQL.ProcedureParameter("_campaign_hashtag", Campaign.Hashtag);
            mySQL.ProcedureParameter("_activist_user_name", ActivistUser.UserName);
            mySQL.ProcedureParameter("_added_cash", Cash);
            mySQL.ProcedureParameter("_tweeter_retweets", Retweets);
            mySQL.ProceduteExecute();
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
                DataRow dataRow = dataTable.NewRow();
                dataRow["clmnHashtag"] = tweet.Campaign.Hashtag;
                dataRow["clmnWebpage"] = tweet.ActivistUser.UserName;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }



    }
}
