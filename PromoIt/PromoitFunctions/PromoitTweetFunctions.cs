using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using PromotItLibrary.Models;
using PromotItLibrary.Classes;
using System.Threading;
using PromotItLibrary.AzureFunctions;

namespace PromoitFunction
{
    public static class PromoitTweetFunctions
    {
        [FunctionName("PromoitTweetFunctions")]
        public static async Task<IActionResult> Run(
                    [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
                    ILogger log)
            =>  await PromoitTweetAzure.RunAzure(req, log, Configuration.DatabaseMode, "Azue Function");
    }
}
