using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoitConsole
{
    public struct ArthurZarankin_Develop
    {
        public static void Run()
        {


            string url = "http://localhost:7071/api/GetUser";


            Console.WriteLine("Wait...[and press Enter]");

            Users user = new Users();
            user.UserName = "npo";
            user.UserPassword = "12345";


            NonProfitUser userToRegiser = new NonProfitUser();
            userToRegiser.Name = "aaaaaaaaaa adssgsdgs";
            userToRegiser.UserName = "aaaaaaaaadssgsdg2";
            userToRegiser.UserPassword = "aaaaaaaaaaadssgsdg";
            userToRegiser.Email = "aaaaaaaaaaadssgsdg";
            userToRegiser.WebSite = "aaaaaaaaaaadssgsdg";

            while (true)
            {
                try
                {
                    //// 2 Insert 1 user (Post)
                    Console.WriteLine($"Insert the user ({userToRegiser.UserName}) get ok/fail answare:");
                    Console.ReadLine();
                    string data = Functions.ObjectToJsonString(userToRegiser);

                    PostSingleDataRequest(url, data);


                    //Users? userResult =  await GetSingleDataRequest<Users>("GetUser", user);
                    //Console.WriteLine(userResult?.UserType);

                    //// 1 Select 1 user (Login) (Get)
                    //Console.WriteLine($"Send the user ({user.UserName}) throth the function get his type:");
                    //Console.ReadLine();
                    //Users? userResult =  await GetSingleDataRequest<Users>("GetUser", user);
                    //Console.WriteLine(userResult?.UserType);
                }
                catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

            }
        }


        async static void PostSingleDataRequest(string url, string data) // another check method 
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("data", data)

            };
            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpResponseMessage response = await (Configuration.HttpClient).PostAsync(url, q);
            using HttpContent content = response.Content;
            //Response
            string mycontent = await content.ReadAsStringAsync();
            Console.WriteLine(mycontent);
        }


        async static Task<T?> GetSingleDataRequest<T>(string getFolder, T obj)
        {
            string objString = Functions.ObjectToJsonString(obj);
            string getRequest = "?data=" + objString;
            //Response
            string? mycontent = await GetRequest(getFolder, getRequest);
            T? t = Functions.JsonStringToSingleObject<T>(mycontent);
            return t;
        }

        async static Task<string> GetRequest(string getFolder, string getRequest)
        {
            using HttpResponseMessage response = await (Configuration.HttpClient).GetAsync(Configuration.FunctionUrl + getFolder + getRequest);
            using HttpContent content = response.Content;
            //Response
            string mycontent = await content.ReadAsStringAsync();
            return mycontent;
        }



    }
    }
}
