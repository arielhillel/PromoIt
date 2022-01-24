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
        public Users NonProfitUser { get; set; }

        private static MySQL mySQL = Configuration.MySQL;

        public Campaign()
        {
            NonProfitUser = Configuration.LoginUser ?? new Users();
        }

        public MySqlDataAdapter GetNonProfitCampaigns()
        {
            mySQL.SetQuary("SELECT * FROM campaigns where non_profit_user_name=@np_user_name ");
            mySQL.QuaryParameter("np_user_name", NonProfitUser.UserName);
            return mySQL.QuaryDataAdapter();
        }

        public bool SetNewCampaign()
        {
            mySQL.Procedure("add_campaign");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_hashtag", Hashtag);
            mySQL.SetParameter("_webpage", Url);
            mySQL.SetParameter("_non_profit_user_name", Configuration.LoginUser.UserName);
            return mySQL.ProceduteExecute();
        }
        public bool DeleteCampaign(string hashtag)
        {
            mySQL.Procedure("delete_campaign");
            mySQL.QuaryParameter("_hashtag", hashtag);            
            return mySQL.ProceduteExecute();
        }
        
        public static DataTable GetAllCampaignsBusiness()
        {
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] {  "clmnHashtag", "clmnWebpage" }) //"clmnCampaignName", "clmnCreator"
                dataTable.Columns.Add(culmn);
            //mySQL.Procedute("getstudents");
            mySQL.Quary("SELECT * FROM campaigns"); //replace with mySQL.Procedure() //add LIMIT 20 ~
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("clmnHashtag", "hashtag"), ("clmnWebpage", "webpage") }) // ,("clmnCampaignName", "name"), ("clmnCreator", "non_profit_user_name")
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }
        public DataTable GetAllCampaignsNonProfit() 
            {
            // Error, no npo user
            if (NonProfitUser.UserType != "non-profit" && NonProfitUser.UserName == null) throw new Exception("No set for npo User");
                DataTable dataTable = new DataTable();
                // Creating the same Grid clmns on the table
                foreach (string culmn in new[] { "clmnCampaignName", "clmnHashtag", "clmnWebsite", "clmnCreator" })
                    dataTable.Columns.Add(culmn);
                //mySQL.Procedute("getstudents");
                mySQL.Quary("SELECT * FROM campaigns where non_profit_user_name=@np_user_name"); //replace with mySQL.Procedure() //add LIMIT 20 ~
                mySQL.ProcedureParameter("np_user_name", NonProfitUser.UserName);
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                while (results != null && results.Read()) //for 1 result: if (mdr.Read())
                {
                    try
                    {
                        DataRow dataRow = dataTable.NewRow();
                        foreach (var (key, value) in new[] { ("clmnCampaignName", "name"), ("clmnHashtag", "hashtag"), ("clmnWebsite", "webpage"), ("clmnCreator", "non_profit_user_name") })
                            dataRow[key] = results.GetValue(value);
                        dataTable.Rows.Add(dataRow);
                    }
                    catch { };
                }
                return dataTable;
            }

    }
}