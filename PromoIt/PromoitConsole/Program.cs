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
using PromoitTwitterAPI;
namespace PromoitConsole
{
    public class Program
    {
        private MySQL mySQL = Configuration.MySQL;
        private static TwitterClient twitterUserClient = Configuration.TwitterUserClient;

        static async Task Main(string[] args)
        {

            List<Tweet> tweetList = await TwitterApiFunction.TweetsPerCampaign_DatabaseCount_ListAsync();

        }
    }
}
