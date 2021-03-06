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
using Microsoft.Extensions.Logging;
using System.Threading;

/**
 * Copyright:
 *  Authors: Arthur Zarankin, Ariel Hillel, Yaron Malul
**/

namespace PromotItLibrary.Models
{
    public class Configuration
    {

        ///     Please install MySQL from file "Promoit-Database-MySQL.sql"
        ///     Please Set the MySQL Local connection data 
        ///     Please run all the 4 projects together:
        ///           PromotItFormApp
        ///           PromoitTwitterAPI
        ///           PromoitFunctions
        ///           PromoitQueue

        private static string _mysqlLocal_Server = "localhost";
        private static string _mysqlLocal_UserId = "root";
        private static string _mysqlLocal_Password = "admin";
        private static string _mysqlLocal_Database = "promoit";


        /// <summary>
        /// System global mode settings
        /// </summary>

        public static Modes LocalMode { get; set; } = Modes.Local;   //Mode s.Local or Modes.NotLocal //Local is for testing purposes
        public static Modes Mode { get; set; } = Modes.Queue; // Modes.Queue or Modes.Functions or Modes.Null /null
        public static Modes DatabaseMode { get; set; } = Modes.MySQL; // Modes.MySQL only



        /// <summary>
        /// Tries Counter
        /// </summary>
        private static int _tries = TriesReset();
        private static int Tries { get { return _tries; } set { _tries = value; } }
        public static int TriesReset() { Tries = 0; return _tries; }    
        public static bool IsTries() { Thread.Sleep(500 * _tries); return Tries++ < 3; }   //Nober of tries is 3 //between tries 500ms


        /// <summary>
        /// Public Sources
        /// </summary>
        public static Users CorrentUser { get; set; }
        public static Users LognUser { get; set; }
        public static Campaign CorrentCampaign { get; set; }
        public static ProductInCampaign CorrentProduct { get; set; }
        public static MySQL MySQL { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        public static HttpClient HttpClient { get { HttpClientStart(); return _httpClient; } set { _httpClient = value; } }
        public static string Message { get; set; }
        public static TwitterClient TwitterUserClient { get { TwitterUserClientStart(); return _twitterUserClient; } set { _twitterUserClient = value; } }


        /// <summary>
        /// Sorces start private functions
        /// </summary>
        /// 
        private static void TwitterUserClientStart() => TwitterUserClient = _twitterUserClient ?? new TwitterClient(APIKey, APISecret, APIToken, APITokenSecret);
        private static void MySQLStart()
            => MySQL = 
                (
                    (LocalMode == Modes.NotLocal) ? _mySQL ?? new MySQL("promoit-db.mysql.database.azure.com", "arielhillel", "PromoIt9023014", "promoit")
                    : (LocalMode == Modes.Local) ? _mySQL ?? new MySQL(_mysqlLocal_Server, _mysqlLocal_UserId, _mysqlLocal_Password, _mysqlLocal_Database)
                    : _mySQL ?? null
                );

        private static void HttpClientStart() => HttpClient = _httpClient ?? new HttpClient();



        /// <summary>
        /// Queue Addresses
        /// </summary>
        public static string PromoitCampaignQueue { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitqueue.azurewebsites.net/api/PromoitCampaignQueue?code=CzfqXFeMMrzJOVySkjakHYddls9pKVIa3WEMQ9Euk11Ozms4b0EJTA=="
                : LocalMode == Modes.Local ? "http://localhost:7076/api/PromoitCampaignQueue"
                : "";
        public static string PromoitProductQueue { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitqueue.azurewebsites.net/api/PromoitProductQueue?code=cssaeHGAJ4X2MolpVgZHhnMKyJhONXtzTa2LVwLE21cxs4aGDovkdQ=="
                : LocalMode == Modes.Local ? "http://localhost:7076/api/PromoitProductQueue"
                : "";
        public static string PromoitTweetQueue { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitqueue.azurewebsites.net/api/PromoitTweetQueue?code=2uN3kFh5da9c22mC0TSdWe2sp7xSb9qAnWYY5q0cWRGVFkbpLsXJfA=="
                : LocalMode == Modes.Local ? "http://localhost:7076/api/PromoitTweetQueue"
                : "";
        public static string SetUserQueue { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitqueue.azurewebsites.net/api/SetUserQueue?code=sPLctsjOKq1KZzZzbZLk8QRSZd6WWaVLet56KkntEu0FG9tDgpKnfQ=="
                : LocalMode == Modes.Local ? "http://localhost:7076/api/SetUserQueue"
                : "";



        /// <summary>
        /// Functions Addresses
        /// </summary>
        public static string PromoitCampaignFunctions { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitfunctions.azurewebsites.net/api/PromoitCampaignFunctions?code=4eO//Ox3YpaYcEh9eO8TU7Q80Z15a5CjUiU76LwtRuYHpvOBotOrFA=="
                : LocalMode == Modes.Local ? "http://localhost:7074/api/PromoitCampaignFunctions"
                : "";
        public static string PromoitProductFunctions { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitfunctions.azurewebsites.net/api/PromoitProductFunctions?code=q70fpS79wKahROnIkrEEBdDrCWI8KXznnwhOG1Q/fezUMFsdnu2WNg=="
                : LocalMode == Modes.Local ? "http://localhost:7074/api/PromoitProductFunctions"
                : "";
        public static string PromoitTweetFunctions { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitfunctions.azurewebsites.net/api/PromoitTweetFunctions?code=xrnkBdiGMGqZvV72kStF3YNJmcRwF6C8vcMNgHLKbC9DHXfaQdjCWQ=="
                : LocalMode == Modes.Local ? "http://localhost:7074/api/PromoitTweetFunctions"
                : "";
        public static string SetUserFunctions { get; set; } =
            LocalMode == Modes.NotLocal ? "https://promoitfunctions.azurewebsites.net/api/SetUser?code=zmxBUYwSG6YVlh7D0ZRBavd7YaEW4n3CnaOsiAROloak/3JX9Ge/HA=="
                : LocalMode == Modes.Local ? "http://localhost:7074/api/SetUser"
                : "";


        /// <summary>
        /// Private Sources
        /// </summary>
        private static MySQL _mySQL;
        private static HttpClient _httpClient;
        private static TwitterClient _twitterUserClient;

        /// <summary>
        /// Twitter API keys
        /// </summary>
        private static string APIKey = "w0KWvkEaKehQUu6qNUx5rsb1f";
        private static string APISecret = "XRJRoCLUMOIiqncw00uQikWxRxxDHT2tQ2YIWwrrMQX5ujQwZC";
        private static string APIToken = "1342513925515046912-EvpeAWTw5ixCneJKuBgSFdD7At8RXD";
        private static string APITokenSecret = "nVlxITA0DfmSjfo5ndcO9mcxkxypS6u4VZeeqDB4FM5Gf";

        /// <summary>
        /// Sources Dispose
        /// </summary>
        ~Configuration() 
        { 
            HttpClient.Dispose();
        }
    }

}
