using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Tweetinvi;
using Tweetinvi.Parameters;
using PromoitTwitterAPI;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace PromoitConsole
{
    public class Program
    {

        private static ILogger<object> _logger = (ILogger<object>) (new ServiceCollection().AddLogging().BuildServiceProvider()).GetService<ILoggerFactory>().CreateLogger<object>();
        private MySQL mySQL = Configuration.MySQL;
        private static TwitterClient twitterUserClient = Configuration.TwitterUserClient;

        static async Task Main(string[] args)
        {




            using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            var a = () =>
            {
                cancellationTokenSource.CancelAfter(10000000);
                while (true) { }
            };

            
            

            _ = Task.Run(async () => { await Task.Delay(TimeSpan.FromMinutes(1)); cancellationTokenSource.Cancel(); });



            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromMinutes(10);
            Console.WriteLine("asdsad");








         
            var token1 = cancellationTokenSource.Token;

            cancellationTokenSource.Cancel();
            try
            {
                if (token1.IsCancellationRequested)
                    token1.ThrowIfCancellationRequested();
                Console.WriteLine("hi");
            }
            catch { }
            Console.WriteLine("1");

           



            //Configuration.Mode = Modes.Functions;
            //new MySQL("localhost", "root", "admin", "promoit"); ;

            //List<Tweet> tweetList = await TwitterApiFunction.TweetsPerCampaign_DatabaseCount_ListAsync(_logger);
            Console.ReadLine();
        }
    }
}
