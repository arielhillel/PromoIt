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
        public string Name { get; set; }
        public string Hashtag { get; set; }
        public string Url { get; set; }


        public static DataTable ShowCampaigns(MySQL mySQL) 
        {
            // Error, no npo user
            if (Configuration.LoginUser == null && Configuration.LoginUser?.Name == null) return null;

            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "clmnCampaignName", "clmnHashtag", "clmnWebsite", "clmnCreator" })
                dataTable.Columns.Add(culmn);

            //mySQL.Procedute("getstudents");
            mySQL.Quary("SELECT * FROM promoit.campaigns where non_profit_user_name=@name"); //replace with mySQL.Procedure() //add LIMIT 20 ~
            mySQL.ProcedureParameter("name", "npo"); // = mySQL.QuaryParameter(,)
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    DataRow? dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("clmnCampaignName", "name"), ("clmnHashtag", "hashtag"), ("clmnWebsite", "webpage"), ("clmnCreator", "non_profit_user_name") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }


        public bool InsertNewCampaign(MySQL mySQL)
        {
            mySQL.Procedure("add_campaign");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_hashtag", Hashtag);
            mySQL.SetParameter("_webpage", Url);
            mySQL.SetParameter("_non_profit_user_name", Configuration.LoginUser.UserName);
            return mySQL.ProceduteExecute();
        }

        public bool UpdateCampaign(MySQL mySQL)
        {
            mySQL.Procedure("update_campaign");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_hashtag", Hashtag);
            mySQL.SetParameter("_webpage", Url);            
            return mySQL.ProceduteExecute();
        }

        public bool DeleteCampaign(MySQL mySQL)
        {
            mySQL.Procedure("delete_campaign");            
            mySQL.SetParameter("_hashtag", Hashtag);            
            return mySQL.ProceduteExecute();
        }
        
        public bool DisplayAndSearch(MySQL mySQL)
        {
            mySQL.Procedure("npo_display_search");            
            mySQL.SetParameter("_non_profit_user_name", Configuration.LoginUser.UserName);
            return mySQL.ProceduteExecute();
        }

    }
}