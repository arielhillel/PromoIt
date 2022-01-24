using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using Newtonsoft.Json;

namespace PromoitConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            if(Configuration.Mode == Modes.MySQL) Console.WriteLine($"DSFSDFSDFDSFSD");

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
                    Console.WriteLine($"Insert the user ({userToRegiser.UserName}) get ok/fail answare:");
                    Console.ReadLine();
                    

                }
                catch (Exception ex) { Console.WriteLine("Fail"); Console.WriteLine(ex); }

            }


        }

    }
}

