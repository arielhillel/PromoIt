using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PromotItLibrary.Classes;
using Serilog;
using Serilog.Sinks.File;

namespace PromotItLibrary.Models
{
    public class Loggings
    {
        public static ILogger<Campaign> CampaignsLog { get; set; } = setLogger<Campaign>(@"../../../../../Logs/Campaigns/CampaignLog.txt");
        public static ILogger<Users> UsersLog { get; set; } = setLogger<Users>(@"../../../../../Logs/Users/UsersLog.txt");
        public static ILogger<Tweet> TweeterLogs { get; set; } = setLogger<Tweet>(@"../../../../../Logs/Tweets/TweetLogs.txt");
        public static ILogger<object> ErrorLogs { get; set; } = setLogger<object>(@"../../../../../Logs/Errors/ErrorLogs.txt");

        private static ServiceProvider _serviceProvider(string address) => new ServiceCollection()
                .AddLogging
                (
                    builder =>
                    {
                        LoggerConfiguration loggerConfiguration = new LoggerConfiguration().WriteTo.File(address, rollingInterval: RollingInterval.Day);
                        builder.AddSerilog(loggerConfiguration.CreateLogger()); builder.SetMinimumLevel(LogLevel.Trace); //builder.AddDebug(); //builder.AddConsole();
                        }
                )
                // .AddSingleton<IVehicleDataReader, VehicleDataReader>()
                .BuildServiceProvider();

        public static ILogger<T> setLogger<T>(string address)

        {

            return (ILogger<T>)_serviceProvider(address).GetService<ILoggerFactory>().CreateLogger<T>();
        }

    }
}
