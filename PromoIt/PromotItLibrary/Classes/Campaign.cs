using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool DeleteCampaign(MySQL mySQL,string hashtag)
        {
            mySQL.Procedure("delete_campaign");
            mySQL.QuaryParameter("_hashtag", hashtag);            
            return mySQL.ProceduteExecute();
        }
        
        public MySqlDataAdapter DisplayAndSearch(MySQL mySQL)
        {
            mySQL.SetQuary("SELECT * FROM campaigns WHERE non_profit_user_name = @non_profit_user_name");
            mySQL.QuaryParameter("@non_profit_user_name", Configuration.LoginUser.UserName);
            return mySQL.QuaryDataAdapter();
        }

        public MySqlDataAdapter DisplayAndSearchAll(MySQL mySQL)
        {
            mySQL.SetQuary("SELECT hashtag, webpage FROM campaigns");
            return mySQL.QuaryDataAdapter();
        }
    }
}