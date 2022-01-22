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


        public static Users LoginUser { get; set; }
        public static MySQL MySQL { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        public static HttpClient HttpClient { get { HttpClientStart(); return _httpClient; } set { _httpClient = value; } }
        public static string FunctionUrl { get; set; } = "http://localhost:7071/api/";

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
