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

namespace PromotItLibrary.Models
{
    public class Configuration
    {
        public static Modes Mode { get; set; } = Modes.Functions;   //Modes.Functions
        public static Modes DatabaseMode { get; set; } = Modes.MySQL;
        public static Users CorrentUser { get; set; }
        public static Users LognUser { get; set; }
        public static Campaign CorrentCampaign { get; set; }
        public static ProductInCampaign CorrentProduct { get; set; }
        public static MySQL MySQL { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        public static HttpClient HttpClient { get { HttpClientStart(); return _httpClient; } set { _httpClient = value; } }
        public static string FunctionUrl { get; set; } = "http://localhost:7071/api/";
        public static string Message { get; set; }
        public static TwitterClient TwitterUserClient { get { TwitterUserClientStart(); return _twitterUserClient; } set { _twitterUserClient = value; } }


        private static void TwitterUserClientStart() => TwitterUserClient = _twitterUserClient ?? new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);
        private static void MySQLStart() => MySQL = _mySQL ?? new MySQL("promoit-db.mysql.database.azure.com", "arielhillel", "PromoIt9023014", "promoit");
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
