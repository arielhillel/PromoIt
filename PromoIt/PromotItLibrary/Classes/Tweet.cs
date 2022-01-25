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

        public Campaign Campaign { get; set; }
        public ActivistUser ActivistUser { get; set; }
        public double Cash { get; set; }
        public int Retweets { get; set; }

        private static MySQL mySQL = Configuration.MySQL;



        public Tweet(string tweetsId, int retweets, string username, string authorId, string hashtag, string url)
        {
            TweetsId = tweetsId;
            Username = username;
            AuthorId = authorId;
            Hashtag = hashtag;
            URL = url;
        }

        private string TweetsId { get; }
   //     private int Retweets { get; }
        private string Username { get; }
        private string AuthorId { get; }
        public string Hashtag { get; }
        public string URL { get; }



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
