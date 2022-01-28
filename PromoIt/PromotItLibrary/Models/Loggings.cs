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
        public static ILogger<object> CampaignsLog { get; set; } = setLogger<object>(@"../../../../../LogFiles/Campaigns/CampaignLog.txt");
        public static ILogger<object> UsersLog { get; set; } = setLogger<object>(@"../../../../../LogFiles/Users/UsersLog.txt");
        public static ILogger<object> TweeterLogs { get; set; } = setLogger<object>(@"../../../../../LogFiles/Tweets/TweetLogs.txt");


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
