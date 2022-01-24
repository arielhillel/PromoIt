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
        public static async Task RunAsync()
        {
            static async Task Main(string[] args)
            {

                Console.WriteLine("Wait...[and press Enter]");

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
                        ////// 2 Insert 1 user (Post)
                        //Console.WriteLine($"Insert the user ({userToRegiser.UserName}) get ok/fail answare:");
                        //Console.ReadLine();
                        //string data = Functions.ObjectToJsonString(userToRegiser);
                        //PostSingleDataRequest(url, data);


                        // 1 Select 1 user (Login) (Get)
                        Users user = new Users();
                        user.UserName = "n+po";
                        user.UserPassword = "123 44445";
                        Console.WriteLine($"Send the user ({user.UserName}) throth the function get his type:");
                        Console.ReadLine();

                        Users? userResult = await Functions.GetSingleDataRequest<Users>("GetUser", user);
                        Console.WriteLine(userResult?.UserType);
                    }
                    catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

                }



            }

        }
    }
}

