using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
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

        public bool InsertNewCampaign(MySQL mySQL)
        {
            mySQL.Procedure("add_campaign");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_hashtag", Hashtag);
            mySQL.SetParameter("_webpage", Url);
            mySQL.SetParameter("_non_profit", Configuration.LoginUser.UserName);
            return mySQL.ProceduteExecute();
        }
    }
}