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

namespace PromoitFunction
{
    public static class Function1
    {
        [FunctionName("GetUser")]
        public static async Task<IActionResult> Run(
                    [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
                    ILogger log)
        {
            string className = "User";
            log.LogInformation($"Function Find {className} Activated");

            try
            {   //get
                string data = req.Query["data"];
                if (data != null)
                {
                    Users user = Functions.JsonStringToSingleObject<Users>(data);    //var userJson = user = Functions.JsonStrinToObjectList<Users>(data);
                    if (user == null) throw new Exception($"GET: No {className} IS Enterd");
                    try
                    {
                        user = user.Login(Configuration.MySql);
                        if (user == null) throw new Exception($"GET: No {className} Found In Databae!");
                        log.LogInformation($"Function Find {className} ({user.Name}) Type ({user.UserType})");
                        return new OkObjectResult(Functions.ObjectToJsonString(user));
                    }
                    catch (Exception ex) { log.LogInformation($"Function GET ({className}) Datanase SELECT/GET-data Fail:\n{ex.Message}"); }
                }
            }
            catch (Exception ex) { log.LogInformation($"Function GET ({className}) Error Fail:{ex.Message}"); }

            try
            {   //post
                using StreamReader streamReader = new StreamReader(req.Body);
                string requestBody = await streamReader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(requestBody))
                {
                    Dictionary<string, string> keyValuePairs = Functions.PostMessageSplit(requestBody);
                    string data = keyValuePairs["data"].ToString();
                    data = Functions.HttpUrlDecode(data);
                    NonProfitUser user = Functions.JsonStringToSingleObject<NonProfitUser>(data);
                    if (user == null) throw new Exception($"POST: No {className} IS Enterd");
                    try 
                    {
                        bool action = user.Register(Configuration.MySql);
                        if (action)
                        {
                            log.LogInformation($"Function Seccess to Insert {className} to database");
                            return new OkObjectResult("ok");
                        }
                    }
                    catch (Exception ex) 
                    {
                        log.LogInformation($"Function Not-Seccess to Insert {className} to database\nDetails:{ex}");
                        return new BadRequestObjectResult("fail");
                    }
                    log.LogInformation($"Function Failed to Insert after Tried to Insert {className} to database");
                    return new BadRequestObjectResult("no access to database");
                } 
            }
            catch (Exception ex) { log.LogInformation($"Function POST ({className}) Error Fail:{ex.Message}"); return new BadRequestObjectResult($"Function Error Fail:{ex.Message}"); }

            return new BadRequestObjectResult("");//No Results
        }
    }
}
