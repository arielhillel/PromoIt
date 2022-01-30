using Moq;
using PromoitTesting.TestClasses;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;
using PromotItLibrary.Models;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Tweetinvi;
using Tweetinvi.Parameters;

namespace PromoitTesting
{

    public class Tweet_TwitterTest
    {

        private static TwitterClient twitterUserClient = Configuration.TwitterUserClient;


        public static string guidNumber = Guid.NewGuid().ToString("n");
        public ProductDonated testingProductDonated() 
        {

            ProductDonated productDonated = new ProductDonated();
            productDonated.ProductInCampaign.Name = "#" + guidNumber;       //instead #
            productDonated.Quantity = "-";
            productDonated.ActivistUser.UserName = "Testing Procces For Twitter Addd";
            productDonated.ProductInCampaign.BusinessUser.UserName = "-";
            productDonated.ProductInCampaign.Id = "-";
            return productDonated;
        }

        [Fact]
        public async Task Tweet_Twitter_Test()
        {
            ProductDonated productDonated = testingProductDonated();
            await productDonated.SetTwitterMessagTweet_SetBuyAnItemAsync();

            int attempts = 10;
            bool isAtweet = false;
            var searchIterator = twitterUserClient.SearchV2.GetSearchTweetsV2Iterator(productDonated.ProductInCampaign.Name);  //#
            while (!searchIterator.Completed)
            {
                try
                {
                    var searchPage = await searchIterator.NextPageAsync();
                    if (searchPage.Content.Tweets.Length >= 1) { isAtweet = true; }

                    break;
                }
                catch { if (attempts-- <= 0) { break; } }
            }

            Assert.True(isAtweet, "Tweet Shoul Sert And found here https://twitter.com/MalulYaron");

        }

    }
}
