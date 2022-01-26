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
        private MySQL mySQL = Configuration.MySQL;
        private static TwitterClient twitterUserClient = Configuration.TwitterUserClient;

        static async Task Main(string[] args)
        {









            List<Tweet> tweetList = new List<Tweet>();

            Campaign campaign1 = new Campaign();
            List<Campaign> campaignList = await campaign1.MySQL_GetAllCampaigns_ListAsync(Configuration.DatabaseMode);    //MYSQL QUERY

            foreach (Campaign campaign in campaignList)    // Each Campaogn
            {

                var searchIterator = twitterUserClient.SearchV2.GetSearchTweetsV2Iterator("#" + campaign.Hashtag);
                if (searchIterator.Completed) continue;
                var searchPage = await searchIterator.NextPageAsync();
                var allTweets = searchPage.Content.Tweets;
                int tweetsCount = allTweets.Length;
                for (int i = 0; i <= tweetsCount - 1; i++)    // Every post
                {

                    if (allTweets[i].Entities.Urls == null) continue;

                    List<string> urlsInTweet = new List<string>();
                    for (int k = 0; k <= allTweets[i].Entities.Urls.Length - 1; k++)    // Every site in post
                    {
                        if (campaign.Url != allTweets[i].Entities.Urls[k].DisplayUrl.ToString()) continue;      //Check Site Url Remained in tweeter post
                        Tweet tweet = new Tweet();
                        tweet.Id = allTweets[i].Id.ToString();
                        tweet.Retweets = allTweets[i].PublicMetrics.RetweetCount;
                        var userResponse = await twitterUserClient.UsersV2.GetUserByIdAsync(allTweets[i].AuthorId);
                        tweet.ActivistUser.UserName = userResponse.User.Username.ToString();
                        tweet.Campaign.Hashtag = campaign.Hashtag;
                        tweet.Cash = 1; //1$
                        tweet.Campaign.Url = campaign.Url;
                        tweet.IsApproved = true;
                        try { await tweet.SetTweetCashAsync(Configuration.DatabaseMode); }  //Database Set
                        catch { tweet.IsApproved = false; }
                        tweetList.Add(tweet);
                        break;
                    }

                }
            }













    }

}
}




//PublishTweet
//var tweetParam = new PublishTweetParameters
//{
//    Text = $"twitter.com #test",
//};
//await userClient.Tweets.PublishTweetAsync(tweetParam);


