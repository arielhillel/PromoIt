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
    public struct PromoitCampaignAzure
    {
        public static async Task<IActionResult> RunAzure(HttpRequest req, ILogger log, Modes FunctionOrDatabaseMode, string azureFunctionString = "")
        {

            string className = "Data";
            log.LogInformation($"{azureFunctionString} Find {className} Activated");

            try
            {   //get
                string data = req.Query["data"];
                string type = req.Query["type"];
                if (data != null && type != null)
                {

                    try
                    {
                        if (type == "GetAllCampaignsNonProfit")
                        {
                            className = "Get Campaign List for NonProfit";
                            Campaign campaign = Functions.JsonStringToSingleObject<Campaign>(data);
                            if (campaign == null) throw new Exception($"GET: No {className} Found In Databae!");
                            List<Campaign> campaignList = await campaign.MySql_GetAllCampaignsNonProfit_ListAsync(FunctionOrDatabaseMode);
                            log.LogInformation($"{azureFunctionString} Found {className}");
                            return new OkObjectResult(Functions.ObjectToJsonString(campaignList));
                        }

                        if (type == "GetAllCampaigns")
                        {
                            className = "Get Campaign List";
                            Campaign campaign = Functions.JsonStringToSingleObject<Campaign>(data);
                            if (campaign == null) throw new Exception($"GET: No {className} Found In Databae!");
                            List<Campaign> campaignList = await campaign.MySQL_GetAllCampaigns_ListAsync(FunctionOrDatabaseMode);
                            log.LogInformation($"{azureFunctionString} Found {className}");
                            return new OkObjectResult(Functions.ObjectToJsonString(campaignList));
                        }

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
                    string type = keyValuePairs["type"].ToString();
                    try
                    {
                        bool action = false;
                        switch (type)
                        {
                            case "SetNewCampaign":
                                className = "Add Campaign";
                                Campaign campaign = Functions.JsonStringToSingleObject<Campaign>(data);
                                if (campaign == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await campaign.SetNewCampaignAsync(FunctionOrDatabaseMode);
                                break;

                            case "DeleteCampaign":
                                className = "Delete Campaign";
                                Campaign campaign2 = Functions.JsonStringToSingleObject<Campaign>(data);
                                if (campaign2 == null) throw new Exception($"POST: No {className} IS Enterd");
                                action = await campaign2.DeleteCampaignAsync(FunctionOrDatabaseMode);
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
                    return new BadRequestObjectResult("(4) No access to database for" + type);
                }
            }
            catch (Exception ex) { log.LogInformation($"{azureFunctionString} POST ({className}) Error Fail:{ex.Message}"); return new BadRequestObjectResult($"Function Error Fail:{ex.Message}"); }

            return new BadRequestObjectResult("");//No Results

        }

    }
}
