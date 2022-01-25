using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class BusinessUser : Users
    {
        public BusinessUser() : base() => UserType = "business";

        public async Task<bool> RegisterAsync(Modes mode = null)
        {

            if ((mode ?? Configuration.Mode) == Modes.MySQL)
            {
                MySQL mySQL = Configuration.MySQL;
                mySQL.Procedure("register_business");
                mySQL.SetParameter("_username", UserName);
                mySQL.SetParameter("_password", UserPassword);
                mySQL.SetParameter("_name", Name);
                return mySQL.ProceduteExecute();
            }

            else if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try { return (bool)await Functions.PostSingleDataRequest("SetUser", this, ""); }
                catch { throw new Exception($"Functions error"); };
            }

            return false;
        }

    }
}
