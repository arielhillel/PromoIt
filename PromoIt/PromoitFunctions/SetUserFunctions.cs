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
    public static class SetUserFunctions
    {
        [FunctionName("SetUser")]
        public static async Task<IActionResult> Run(
                    [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
                    ILogger log)
        {
            string className = "User";
            log.LogInformation($"Function Find {className} Activated");

            try
            {   //get
                string data = req.Query["data"];
                string type = req.Query["type"];
                if (data != null)
                {
                    if(type == "GetAllUsers")
                    {
                        className = "Get All Users List";
                        //Users user1 = Functions.JsonStringToSingleObject<Users>(data);
                        //if (user == null) throw new Exception($"GET: No {className} Found In Databae!");
                        AdminUser adminUser = new AdminUser();
                        List<Users> userList = await adminUser.MySQL_GetAllUsers_ListAsync(Configuration.DatabaseMode);
                        log.LogInformation($"Function Found {className}");
                        return new OkObjectResult(Functions.ObjectToJsonString(userList));
                    }


                    Users user = Functions.JsonStringToSingleObject<Users>(data);    //var userJson = user = Functions.JsonStrinToObjectList<Users>(data);
                    if (user == null) throw new Exception($"GET: No {className} IS Enterd");

                    try
                    {
                        user = user.Login(Configuration.DatabaseMode);
                        if (user == null) throw new Exception($"GET: No {className} Found In Databae!"); 
                        log.LogInformation($"Function Find {className} ({user.Name}) Type ({user.UserType})");

                        return new OkObjectResult(Functions.ObjectToJsonString(user));

                    } catch (Exception ex)  { log.LogInformation($"Function GET ({className}) Datanase SELECT/GET-data Fail:\n{ex.Message}"); return new BadRequestObjectResult($"Not Found ({className})"); }

                }
            } catch (Exception ex) { log.LogInformation($"Function GET ({className}) Error Fail\n{ex.Message}"); }

            try
            {   //post
                using StreamReader streamReader = new StreamReader(req.Body);
                string requestBody = await streamReader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(requestBody))
                {
                    requestBody=Functions.HttpUrlDecode(requestBody);
                       Dictionary<string, string> keyValuePairs = Functions.PostMessageSplit(requestBody);
                      string data = keyValuePairs["data"].ToString();
                    try 
                    {


                        dynamic userDataDynamic = Functions.JsonStringToSingleObject<NonProfitUser>(data);
                        if (userDataDynamic == null) throw new Exception($"POST: No {className} IS Enterd");

                        bool action = false;

                        switch (userDataDynamic.UserType)
                        {
                            case "non-profit":
                                NonProfitUser user = Functions.JsonStringToSingleObject<NonProfitUser>(data);
                                if (user == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user.RegisterAsync(Configuration.DatabaseMode);
                                break;
                            case "admin":
                                AdminUser user2 = Functions.JsonStringToSingleObject<AdminUser>(data);
                                if (user2 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user2.RegisterAsync(Configuration.DatabaseMode);
                                break;
                            case "business":
                                BusinessUser user3 = Functions.JsonStringToSingleObject<BusinessUser>(data);
                                if (user3 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user3.RegisterAsync(Configuration.DatabaseMode);
                                break;
                            case "activist":
                                ActivistUser user4 = Functions.JsonStringToSingleObject<ActivistUser>(data);
                                if (user4 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user4.RegisterAsync(Configuration.DatabaseMode);
                                break;
                            default:
                                break;
                        }

                        if (action)
                        {
                            log.LogInformation($"Function Seccess to Insert {className} to database");
                            return new OkObjectResult("ok");        //good result
                        }




                    }
                    catch (Exception ex) { log.LogInformation($"Function Not-Seccess to Insert {className} to database\nDetails:{ex}");  return new BadRequestObjectResult("fail"); } //bad result
                    log.LogInformation($"Function Failed to Insert after Tried to Insert {className} to database");
                    return new BadRequestObjectResult("no access to database");
                } 
            }
            catch (Exception ex) { log.LogInformation($"Function POST ({className}) Error Fail:{ex.Message}"); return new BadRequestObjectResult($"Function Error Fail:{ex.Message}"); }




            return new BadRequestObjectResult("");//No Results
        }
    }
}
