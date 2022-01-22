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
        public static MySQL MySql { get { MySQLStart(); return _mySQL; } set { _mySQL = value; } }
        //public static HttpClient HttpClient { get; private set; }
        //public static string FunctionUrl { get { HttpClientStart(); return _functionUrl; } set {  _functionUrl = value; } } 

        public static void MySQLStart() => MySql = _mySQL ?? new MySQL("localhost", "root", "admin", "promoit");
        //public static void HttpClientStart() => HttpClient = HttpClient ?? new HttpClient();

        private static MySQL _mySQL;
        private static string _functionUrl = "http://localhost:7071/api/GetUser";

        ~Configuration() 
        { 
           // HttpClient.Dispose();
        }
    }

}
