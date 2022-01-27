using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoitConsole
{
    public struct ArthurZarankin_DevelopFunctions
    {
        public static async Task RunAsync()
        {


            if (Configuration.Mode == Modes.MySQL) Console.WriteLine($"DSFSDFSDFDSFSD");

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

                    bool? result = await Functions.PostSingleDataRequest<NonProfitUser>(Configuration.SetUserFunctions, userToRegiser);
                    if (result == true) Console.WriteLine($"Yesss");
                    else if (result == false) Console.WriteLine($"Noooo");
                    else if (result == null) Console.WriteLine($"Faillll");

                    // 1 Select 1 user (Login) (Get)
                    Users user = new Users();
                    user.UserName = "npo";
                    user.UserPassword = "12344445";
                    Console.WriteLine($"Send the user ({user.UserName}) throth the function get his type:");
                    Console.ReadLine();

                    Users? userResult = await Functions.GetSingleDataRequest<Users>(Configuration.SetUserFunctions, user);
                    Console.WriteLine(userResult?.UserType);
                }
                catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

            }

        }
    }
}

