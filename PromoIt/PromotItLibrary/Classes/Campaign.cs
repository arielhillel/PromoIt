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
            NonProfitUser =  new Users();   //
        }

        public string Name { get; set; }
        public string Hashtag { get; set; }
        public string Url { get; set; }
        public Users NonProfitUser { get; set; }

        private static MySQL mySQL = Configuration.MySQL;

        public bool SetNewCampaign()
        {
            mySQL.Procedure("add_campaign");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_hashtag", Hashtag);
            mySQL.SetParameter("_webpage", Url);
            mySQL.SetParameter("_non_profit_user_name", Configuration.CorrentUser.UserName);
            return mySQL.ProceduteExecute();
        }
        public bool DeleteCampaign(string hashtag)
        {
            mySQL.Procedure("delete_campaign");
            mySQL.QuaryParameter("_hashtag", hashtag);
            return mySQL.ProceduteExecute();
        }





        public List<Campaign> MySql_GetAllCampaignsNonProfit_List() //Non profit
        {
            // Error, no npo user
            if (NonProfitUser.UserType != "non-profit" && NonProfitUser.UserName == null) throw new Exception("No set for npo User");
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

        public DataTable GetAllCampaignsNonProfit_DataTable() //Non profit
        {
            DataTable dataTable = new DataTable();
            List<Campaign> campaignsList = MySql_GetAllCampaignsNonProfit_List();
            foreach (string culmn in new[] { "clmnCampaignName", "clmnHashtag", "clmnWebsite", "clmnCreator" })
                dataTable.Columns.Add(culmn);
            foreach (Campaign campaign in campaignsList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnCampaignName"] = campaign.Name;
                    dataRow["clmnHashtag"] = campaign.Hashtag;
                    dataRow["clmnWebsite"] = campaign.Url;
                    dataRow["clmnCreator"] = campaign.NonProfitUser.UserName;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

        public static List<Campaign> MySQL_GetAllCampaigns_List()//Activist, business, admin, tweets
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

        public static DataTable GetAllCampaigns_DataTable() //Activist and business

        {
            DataTable dataTable = new DataTable();
            List<Campaign> campaignsList = MySQL_GetAllCampaigns_List();
            foreach (string culmn in new[] {  "clmnHashtag", "clmnWebpage" })
                dataTable.Columns.Add(culmn);
            foreach (Campaign campaign in campaignsList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnHashtag"] = campaign.Hashtag;
                    dataRow["clmnWebpage"] = campaign.Url;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

    }
}