using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;

namespace PromoitConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            string url = "http://localhost:7071/api/GetUser";


            Console.WriteLine("Wait...[and press Enter]");

            Users user = new Users();
            user.UserName = "npo";
            user.UserPassword = "12345";


            while (true)
            {

                try
                {
                    Console.WriteLine(":");
                    string name = Console.ReadLine();



                    string userString = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                    GetRequest(url+"?data="+ userString);
                }
                catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

            }
        }


        async static void PostRequest(string url, string name) // another check method 
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("name", name)

            };
            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpClient client = new HttpClient();

            using HttpResponseMessage response = await client.PostAsync(url, q);
            using HttpContent content = response.Content;

            string mycontent = await content.ReadAsStringAsync();
            Console.WriteLine("Post order sent ...");

            System.ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = System.ConsoleColor.Green;

            Console.WriteLine(mycontent);

            Console.ForegroundColor = originalColor;
        }

        async static void GetRequest(string url)
        {
            using HttpClient client = new HttpClient();

            using HttpResponseMessage response = await client.GetAsync(url);

            using HttpContent content = response.Content;

            string mycontent = await content.ReadAsStringAsync();
            Console.WriteLine("Get order sent ...");

            //Response
            System.ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(mycontent);
            Console.ForegroundColor = originalColor;



        }

    }
}

