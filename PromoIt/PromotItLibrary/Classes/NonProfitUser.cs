using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class NonProfitUser : Users
    {
        public NonProfitUser() : base() => UserType = "non-profit";

        public string Email { get; set; }
        public string WebSite { get; set; }

        private MySQL mySQL = Configuration.MySQL;

        public async Task<bool> RegisterAsync(Modes mode = null) 
        {
            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                return (bool)await Functions.PostSingleDataRequest(Configuration.SetUserQueue, this, "");
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return (bool)await Functions.PostSingleDataRequest(Configuration.SetUserFunctions, this, "");
            }
            catch (Exception ex)
            {
                return false;
            }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("register_non_profit");
                mySQL.SetParameter("_username", UserName);
                mySQL.SetParameter("_password", UserPassword);
                mySQL.SetParameter("_name", Name);
                mySQL.SetParameter("_email", Email);
                mySQL.SetParameter("_website", WebSite);
                return mySQL.ProceduteExecute();
            }

            return false;
        }


    }
}
