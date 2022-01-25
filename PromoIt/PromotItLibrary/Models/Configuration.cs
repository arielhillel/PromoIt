using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;

namespace PromotItLibrary.Models
{
    public class Configuration
    {
        public static Modes Mode { get; set; } = Modes.MySQL;   //Modes.Functions
        public static Modes DatabaseMode { get; set; } = Modes.MySQL;
        public static Users CorrentUser { get; set; }
        public static Users LognUser { get; set; }
        public static Campaign CorrentCampaign { get; set; }
        public static ProductInCampaign CorrentProduct { get; set; }
        public static MySQL MySQL { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        public static HttpClient HttpClient { get { HttpClientStart(); return _httpClient; } set { _httpClient = value; } }
        public static string FunctionUrl { get; set; } = "http://localhost:7071/api/";
        public static string Message { get; set; }

        public static void MySQLStart() => MySQL = _mySQL ?? new MySQL("localhost", "root", "admin", "promoit");
        public static void HttpClientStart() => HttpClient = _httpClient ?? new HttpClient();

        private static MySQL _mySQL;
        private static HttpClient _httpClient;

        ~Configuration() 
        { 
            HttpClient.Dispose();
        }
    }

}
