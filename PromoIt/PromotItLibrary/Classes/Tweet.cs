using Microsoft.Extensions.Logging;
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

        public async Task<bool> SetTweetCashAsync(Modes mode = null)
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitTweetQueue, this, "SetTweetCash");
                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitTweetFunctions, this, "SetTweetCash");
            } catch (Exception ex)
            {
                return false;
            }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("add_tweet");
                mySQL.ProcedureParameter("_tweeter_id", long.Parse(Id));
                mySQL.ProcedureParameter("_campaign_hashtag", Campaign.Hashtag);
                mySQL.ProcedureParameter("_activist_user_name", ActivistUser.UserName);
                mySQL.ProcedureParameter("_added_cash", Cash);
                mySQL.ProcedureParameter("_tweeter_retweets", Retweets);
                return mySQL.ProceduteExecute();
            }
            return false;
        }

        public async Task<List<Tweet>> MySQL_GetAllTweets_ListAsync(Modes mode = null)
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return await Functions.GetMultipleDataRequest(Configuration.PromoitTweetQueue, this, "GetAllTweets");
                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return await Functions.GetMultipleDataRequest(Configuration.PromoitTweetFunctions, this, "GetAllTweets");
            }
            catch (Exception ex)
            {
                return null;
            }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                List<Tweet> tweetList = new List<Tweet>();
                mySQL.Quary("SELECT campaign_hashtag,activist_user_name,retweets FROM tweets");
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                while (results != null && results.Read()) //for 1 result: if (mdr.Read())
                {
                    try
                    {
                        Tweet tweet = new Tweet();
                        tweet.Campaign.Hashtag = results.GetString("campaign_hashtag");
                        tweet.ActivistUser.UserName = results.GetString("activist_user_name");
                        tweet.Retweets = int.Parse(results.GetString("retweets"));
                        tweetList.Add(tweet);
                    }
                    catch { };
                }
                return tweetList;
            }

            return null;

        }

        public async Task<DataTable> GetAllTweets_DataTableAsync()
        {
            DataTable dataTable = new DataTable();
            List<Tweet> tweetList = await MySQL_GetAllTweets_ListAsync();
            foreach (string culmn in new[] { "Hashtag", "UserName", "Retweets" })
                dataTable.Columns.Add(culmn);
            foreach (Tweet tweet in tweetList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Hashtag"] = tweet.Campaign.Hashtag;
                dataRow["UserName"] = tweet.ActivistUser.UserName;
                dataRow["Retweets"] = tweet.Retweets;
                dataTable.Rows.Add(dataRow);
                Loggings.TweeterLogs.LogInformation($"Tweet Campaign Hashtag (#{tweet.Campaign.Hashtag}) UserName ({tweet.ActivistUser.UserName}) Retweets ({tweet.Retweets})");
            }
            return dataTable;
        }

    }
}
