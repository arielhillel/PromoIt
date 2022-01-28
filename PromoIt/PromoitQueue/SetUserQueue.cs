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
using PromotItLibrary.Models;
using PromotItLibrary.AzureFunctions;
using PromotItLibrary.Classes;

namespace PromoitQueue
{
    public static class SetUserQueue
    {
        [FunctionName("SetUserQueue")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
             => await SetUserAzure.RunAzure(req, log, Modes.Functions, "Azue Queue");
    }
}
