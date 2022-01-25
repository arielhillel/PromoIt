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

            if ((mode ?? Configuration.Mode) == Modes.MySQL)
            {
                try { return (bool)await Functions.PostSingleDataRequest("SetUser", this, ""); }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.Mode) == Modes.Functions)
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
