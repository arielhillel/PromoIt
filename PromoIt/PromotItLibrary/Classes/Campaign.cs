using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PromotItLibrary.Classes
{
    public class Campaign
    {        
        public string Name { get; set; }
        public string Hashtag { get; set; }
        public string Url { get; set; }

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
        
        public MySqlDataAdapter DisplayAndSearch(MySQL mySQL)
        {
            mySQL.SetQuary("SELECT * FROM campaigns WHERE non_profit_user_name = @non_profit_user_name");
            mySQL.QuaryParameter("@non_profit_user_name", Configuration.LoginUser.UserName);
            return mySQL.QuaryDataAdapter();
        }
    }
}