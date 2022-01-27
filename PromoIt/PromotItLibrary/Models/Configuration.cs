using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;
using Tweetinvi;
using Tweetinvi.Parameters;

/**
 * Copyright:
 *  Author: Arierl
 *  Email: 
 *  Author: Yaron
 *  Email: 
 *  Author: Arthur Zarankin
 *  Email: w3arthur@gmail.com
 *  Site: http://www.arthur.tk
 *  Begin Date: 14/01/2022
 *  Edited At:  27/01/2022
**/

namespace PromotItLibrary.Models
{
    public class Configuration
    {
        public static Modes Mode { get; set; } = Modes.Functions;   //Modes.Functions
        public static Modes DatabaseMode { get; set; } = Modes.MySQL;

        public static Modes LocalMode { get; set; } = Modes.NotLocal;
        public static string PromoitCampaignFunctions { get; set; } = "http://localhost:7074/api/PromoitCampaignFunctions";
        public static string PromoitProductFunctions { get; set; } = "http://localhost:7074/api/PromoitProductFunctions";
        public static string PromoitTweetFunctions { get; set; } = "http://localhost:7074/api/PromoitTweetFunctions";
        public static string SetUserFunctions { get; set; } = "http://localhost:7074/api/SetUser";

        public static Users CorrentUser { get; set; }
        public static Users LognUser { get; set; }
        public static Campaign CorrentCampaign { get; set; }
        public static ProductInCampaign CorrentProduct { get; set; }
        public static MySQL MySQL { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        public static HttpClient HttpClient { get { HttpClientStart(); return _httpClient; } set { _httpClient = value; } }
        
        public static string Message { get; set; }
        public static TwitterClient TwitterUserClient { get { TwitterUserClientStart(); return _twitterUserClient; } set { _twitterUserClient = value; } }


        private static void TwitterUserClientStart() => TwitterUserClient = _twitterUserClient ?? new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);
        private static void MySQLStart() => MySQL = _mySQL ?? new MySQL("localhost", "root", "admin", "promoit");

        //new MySQL("localhost", "root", "admin", "promoit");
        //new MySQL("151.106.97.192", "u225520479_promoit", "F=gIu0zLg^1", "u225520479_promoit");
        private static void HttpClientStart() => HttpClient = _httpClient ?? new HttpClient();
       
        private static MySQL _mySQL;
        private static HttpClient _httpClient;
        private static TwitterClient _twitterUserClient;
        private static string APIKey = "w0KWvkEaKehQUu6qNUx5rsb1f";
        private static string APISecret = "XRJRoCLUMOIiqncw00uQikWxRxxDHT2tQ2YIWwrrMQX5ujQwZC";
        private static string APIToken = "1342513925515046912-EvpeAWTw5ixCneJKuBgSFdD7At8RXD";
        private static string APITokenSecret = "nVlxITA0DfmSjfo5ndcO9mcxkxypS6u4VZeeqDB4FM5Gf";

        ~Configuration() 
        { 
            HttpClient.Dispose();
            
        }
    }

}
