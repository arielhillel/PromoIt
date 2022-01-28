using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Logging;
using PromotItLibrary.Models;
using PromotItLibrary.Classes;

namespace PromotItLibrary.AzureFunctions
{
    public struct SetUserAzure
    {

        public static async Task<IActionResult> RunAzure(HttpRequest req, ILogger log, Modes FunctionOrDatabaseMode, string azureFunctionString ="") 
        {

            string className = "User";
            log.LogInformation($"{azureFunctionString} Find {className} Activated");

            try
            {   //get
                string data = req.Query["data"];
                string type = req.Query["type"];
                if (data != null)
                {
                    if (type == "GetAllUsers")
                    {
                        className = "Get All Users List";
                        //Users user1 = Functions.JsonStringToSingleObject<Users>(data);
                        //if (user == null) throw new Exception($"GET: No {className} Found In Databae!");
                        AdminUser adminUser = new AdminUser();
                        List<Users> userList = await adminUser.MySQL_GetAllUsers_ListAsync(FunctionOrDatabaseMode);
                        log.LogInformation($"{azureFunctionString} Found {className}");
                        return new OkObjectResult(Functions.ObjectToJsonString(userList));
                    }


                    Users user = Functions.JsonStringToSingleObject<Users>(data);    //var userJson = user = Functions.JsonStrinToObjectList<Users>(data);
                    if (user == null) throw new Exception($"GET: No {className} IS Enterd");

                    try
                    {
                        user = await user.LoginAsync(FunctionOrDatabaseMode);
                        if (user == null) throw new Exception($"GET: No {className} Found In Databae!");
                        log.LogInformation($"{azureFunctionString} Find {className} ({user.Name}) Type ({user.UserType})");

                        return new OkObjectResult(Functions.ObjectToJsonString(user));

                    }
                    catch (Exception ex) { log.LogInformation($"{azureFunctionString} GET ({className}) Datanase SELECT/GET-data Fail:\n{ex.Message}"); return new BadRequestObjectResult($"Not Found ({className})"); }

                }
            }
            catch (Exception ex) { log.LogInformation($"{azureFunctionString} GET ({className}) Error Fail\n{ex.Message}"); }

            try
            {   //post
                using StreamReader streamReader = new StreamReader(req.Body);
                string requestBody = await streamReader.ReadToEndAsync();
                if (!string.IsNullOrEmpty(requestBody))
                {
                    requestBody = Functions.HttpUrlDecode(requestBody);
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
                                action = await user.RegisterAsync(FunctionOrDatabaseMode);
                                break;
                            case "admin":
                                AdminUser user2 = Functions.JsonStringToSingleObject<AdminUser>(data);
                                if (user2 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user2.RegisterAsync(FunctionOrDatabaseMode);
                                break;
                            case "business":
                                BusinessUser user3 = Functions.JsonStringToSingleObject<BusinessUser>(data);
                                if (user3 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user3.RegisterAsync(FunctionOrDatabaseMode);
                                break;
                            case "activist":
                                ActivistUser user4 = Functions.JsonStringToSingleObject<ActivistUser>(data);
                                if (user4 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await user4.RegisterAsync(FunctionOrDatabaseMode);
                                break;
                            default:
                                break;
                        }

                        if (action)
                        {
                            log.LogInformation($"{azureFunctionString} Seccess to Insert {className} to database");
                            return new OkObjectResult("ok");        //good result
                        }

                    }
                    catch (Exception ex) { log.LogInformation($"{azureFunctionString} Not-Seccess to Insert {className} to database\nDetails:{ex}"); return new BadRequestObjectResult("fail"); } //bad result
                    log.LogInformation($"{azureFunctionString} Failed to Insert after Tried to Insert {className} to database");
                    return new BadRequestObjectResult("No access to database");
                }
            }
            catch (Exception ex) { log.LogInformation($"{azureFunctionString} POST ({className}) Error Fail:{ex.Message}"); return new BadRequestObjectResult($"Function Error Fail:{ex.Message}"); }


            return new BadRequestObjectResult("");//No Results

        }

    }
}
