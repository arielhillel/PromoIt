using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using Tweetinvi;
using Tweetinvi.Parameters;

namespace PromoitTwitterAPI
{
    public class TwitterApiTimmer
    {

        private MySQL mySQL = Configuration.MySQL;
        private TwitterClient twitterUserClient = Configuration.TwitterUserClient;

        [FunctionName("TwitterApiTimmerFunction")]
        public async Task RunAsync([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Twitter API Function Started on: {DateTime.Now}");

            List<Tweet> tweetList = new List<Tweet>();

            List<Campaign> campaignList = Campaign.MySQL_GetAllCampaigns_List();    //MYSQL QUERY

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
                        try { tweet.SetTweetCash(); }  //Database Set
                        catch { tweet.IsApproved = false; }
                        tweetList.Add(tweet);
                        break;
                    }

                }
            }

            log.LogInformation($"C# Twitter API Function Started Logs, List of twits");
            foreach (Tweet tweet in tweetList)
            {
                string logString = $"Activist UserName ({tweet.ActivistUser.UserName}) Campaign WebPage ({tweet.Campaign.Url}) Is Approved ({tweet.IsApproved})" +
                        $" \n Retweets ({tweet.Retweets}) Cash PerTweet ({tweet.Cash})  Camaign Hashtag (#{tweet.Campaign.Hashtag}) Id ({tweet.Id})";
                if (tweet.IsApproved) log.LogInformation(logString);
                else log.LogError(logString);
            }

        }
    }
}
