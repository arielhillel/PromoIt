using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Campaign
    {
        public Campaign()
        {
            NonProfitUser =  new Users();
        }

        public string Name { get; set; }
        public string Hashtag { get; set; }
        public string Url { get; set; }
        public Users NonProfitUser { get; set; }

        private static MySQL mySQL = Configuration.MySQL;

        public async Task<bool> SetNewCampaignAsync(Modes mode = null)
        {
            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitCampaignQueue, this, "SetNewCampaign");
                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitCampaignFunctions, this, "SetNewCampaign");
            } 
            catch { return false;}

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("add_campaign");
                mySQL.SetParameter("_name", Name);
                mySQL.SetParameter("_hashtag", Hashtag);
                mySQL.SetParameter("_webpage", Url);
                mySQL.SetParameter("_non_profit_user_name", NonProfitUser.UserName);
                return mySQL.ProceduteExecute();
            }

            return false;
        }
        public async Task<bool> DeleteCampaignAsync(Modes mode = null)
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitCampaignQueue, this, "DeleteCampaign");
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitCampaignFunctions, this, "DeleteCampaign");
            } 
            catch{ return false; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("delete_campaign");
                mySQL.QuaryParameter("_hashtag", Hashtag);
                return mySQL.ProceduteExecute();
            }

            return false;
        }


        public async Task<List<Campaign>> MySql_GetAllCampaignsNonProfit_ListAsync(Modes mode = null) //Non profit
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitCampaignQueue, this, "GetAllCampaignsNonProfit");
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitCampaignFunctions, this, "GetAllCampaignsNonProfit");
            }
            catch { return null; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                // Error, no npo user
                if (NonProfitUser.UserName == null) throw new Exception("No set for npo User");
                mySQL.Quary("SELECT * FROM campaigns where non_profit_user_name=@np_user_name"); //replace with mySQL.Procedure() //add LIMIT 20 ~
                mySQL.ProcedureParameter("np_user_name", NonProfitUser.UserName);
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                List<Campaign> campaignsList = new List<Campaign>();
                while (results != null && results.Read()) //for 1 result: if (mdr.Read())
                {
                    try
                    {
                        Campaign campaign = new Campaign();
                        campaign.Name = results.GetString("name");
                        campaign.Hashtag = results.GetString("hashtag");
                        campaign.Url = results.GetString("webpage");
                        campaign.NonProfitUser.UserName = results.GetString("non_profit_user_name");
                        campaignsList.Add(campaign);
                    }
                    catch { };
                }
                return campaignsList;
            }

            return null;

        }

        public async Task<DataTable> GetAllCampaignsNonProfit_DataTableAsync() //Non profit
        {
            DataTable dataTable = new DataTable();
            List<Campaign> campaignsList = await MySql_GetAllCampaignsNonProfit_ListAsync();
            foreach (string culmn in new[] { "clmnCampaignName", "clmnHashtag", "clmnWebsite", "clmnCreator" })
                dataTable.Columns.Add(culmn);
            foreach (Campaign campaign in campaignsList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["clmnCampaignName"] = campaign.Name;
                dataRow["clmnHashtag"] = campaign.Hashtag;
                dataRow["clmnWebsite"] = campaign.Url;
                dataRow["clmnCreator"] = campaign.NonProfitUser.UserName;
                dataTable.Rows.Add(dataRow);
            }

            if(campaignsList.Count == 0)
                Loggings.ErrorLog($"Non Profit Organization Not have any campaigns to show from GetAllCampaigns, UserName ({NonProfitUser.UserName})");
            else Loggings.ReportLog($"Non Profit Organization GetAllCampaigns, UserName ({NonProfitUser.UserName})");

            return dataTable;
        }

        public async Task<List<Campaign>> MySQL_GetAllCampaigns_ListAsync(Modes mode = null)//Activist, business, admin, tweets
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitCampaignQueue, this, "GetAllCampaigns"); 
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitCampaignFunctions, this, "GetAllCampaigns");
            }
            catch (Exception ex)
            {
                return null;
            }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Quary("SELECT * FROM campaigns");
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                List<Campaign> campaignsList = new List<Campaign>();
                while (results != null && results.Read())
                {
                    try
                    {
                        Campaign campaign = new Campaign();
                        campaign.Hashtag = results.GetString("hashtag");
                        campaign.Url = results.GetString("webpage");
                        campaign.NonProfitUser.UserName = results.GetString("non_profit_user_name");
                        campaignsList.Add(campaign);
                    }
                    catch { };
                }
                return campaignsList;
            }
            return null;

        }

        public async Task<DataTable> GetAllCampaigns_DataTableAsync() //Activist and business

        {
            DataTable dataTable = new DataTable();
            List<Campaign> campaignsList = await MySQL_GetAllCampaigns_ListAsync();
            foreach (string culmn in new[] {  "clmnHashtag", "clmnWebpage" })
                dataTable.Columns.Add(culmn);

            if (campaignsList == null)
            {
                Loggings.ErrorLog($"Cant find any campaign to show from GetAllCampaigns request");
                return dataTable;
            }  
            foreach (Campaign campaign in campaignsList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["clmnHashtag"] = campaign.Hashtag;
                dataRow["clmnWebpage"] = campaign.Url;
                dataTable.Rows.Add(dataRow);
            }

            Loggings.ReportLog($"GetAllCampaigns Requested");

            return dataTable;

        }

    }
}