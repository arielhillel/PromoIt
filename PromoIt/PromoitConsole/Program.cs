using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using Newtonsoft.Json;

using Tweetinvi;
using Tweetinvi.Parameters;

namespace PromoitConsole
{
    public class Program
    {
        private static string APIKey = "w0KWvkEaKehQUu6qNUx5rsb1f";
        private static string APISecret = "XRJRoCLUMOIiqncw00uQikWxRxxDHT2tQ2YIWwrrMQX5ujQwZC";
        private static string APIToken = "1342513925515046912-EvpeAWTw5ixCneJKuBgSFdD7At8RXD";
        private static string APITokenSecret = "nVlxITA0DfmSjfo5ndcO9mcxkxypS6u4VZeeqDB4FM5Gf";

        private static MySQL mySQL = Configuration.MySQL;

        static async Task Main(string[] args)
        {

            List<Tweet> tweetList = new List<Tweet>();


            List<Campaign> campaignList = Campaign.MySQL_GetAllCampaigns_List();    //MYSQL QUERY

            foreach(Campaign campaign in campaignList)    // Each Campaogn
            {
                TwitterClient userClient = new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);
                var searchIterator = userClient.SearchV2.GetSearchTweetsV2Iterator("#"+ campaign.Hashtag );
                if (searchIterator.Completed) continue;
                var searchPage = await searchIterator.NextPageAsync();
                var searchResponse = searchPage.Content;
                var allTweets = searchResponse.Tweets;
                int tweetsCount = allTweets.Length;
                for (int i = 0; i <= tweetsCount - 1; i++)    // Every post
                {
                    Tweet tweet = new Tweet();
                    string tweetsId = allTweets[i].Id;
                    tweet.Retweets = allTweets[i].PublicMetrics.RetweetCount;
                    var userResponse = await userClient.UsersV2.GetUserByIdAsync( allTweets[i].AuthorId );
                    tweet.ActivistUser.UserName = userResponse.User.Username.ToString();

                    if (allTweets[i].Entities.Urls == null) continue;
                    List<string> urlsInTweet = new List<string>();
                    for (int k = 0; k <= allTweets[i].Entities.Urls.Length - 1; k++)    // Every site in post
                    {
                        if (campaign.Url != allTweets[i].Entities.Urls[k].DisplayUrl.ToString() ) continue;      //Check Site Url Remained in tweeter post
                        try 
                        {
                            mySQL.Procedure("add_tweet");
                            mySQL.ProcedureParameter("_tweeter_id", tweetsId);
                            mySQL.ProcedureParameter("_campaign_hashtag", campaign.Hashtag);
                            mySQL.ProcedureParameter("_activist_user_name", tweet.ActivistUser.UserName);
                            mySQL.ProcedureParameter("_added_cash", 1); //1$
                            mySQL.ProcedureParameter("_tweeter_retweets", tweet.Retweets);
                            mySQL.ProceduteExecute();
                        }
                        catch {/*Fail Procedure*/ }

                        tweetList.Add(tweet);

                        break;
                    }
                            

                    
                    
                    

                }
            }

            var a = tweetList;

        }

    }
}




//PublishTweet
//var tweetParam = new PublishTweetParameters
//{
//    Text = $"twitter.com #test",
//};
//await userClient.Tweets.PublishTweetAsync(tweetParam);


