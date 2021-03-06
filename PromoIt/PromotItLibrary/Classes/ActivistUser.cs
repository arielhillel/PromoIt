using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class ActivistUser : Users
    {
        public ActivistUser() : base()  => UserType = "activist"; 
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Cash { get; set; }

        private MySQL mySQL = Configuration.MySQL;

        public async Task<ActivistUser> GetCashAmountAsync(Modes mode = null)
        {

            try
            {
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return await Functions.GetSingleDataRequest(Configuration.PromoitProductQueue, this, "GetCashAmount");

                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return await Functions.GetSingleDataRequest(Configuration.PromoitProductFunctions, this, "GetCashAmount");
            }
            catch { return null; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Quary("SELECT cash FROM promoit.users_activists Where user_name = @_username LIMIT 1");
                mySQL.ProcedureParameter("_username", UserName);
                using MySqlDataReader results = mySQL.GetQueryMultyResults();
                if (results == null) throw new Exception($"no cash {UserName}");
                ActivistUser activistUser = new ActivistUser();
                if (results != null && results.Read())
                {
                    try { activistUser.Cash = results.GetDecimal("cash").ToString() + "$"; }
                    catch { throw new Exception($"error to get cash for {UserName}"); };
                }
                return activistUser;
            }
            return null;

        }

        public async Task<bool> RegisterAsync(Modes mode = null)
        {

            try
            {
                if ((mode ?? Configuration.Mode) == Modes.Queue)

                    return (bool)await Functions.PostSingleDataInsert(Configuration.SetUserQueue, this, "");


                else if ((mode ?? Configuration.Mode) == Modes.Functions)

                    return (bool)await Functions.PostSingleDataInsert(Configuration.SetUserFunctions, this, "");
            }
            catch { return false; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("register_activist");
                mySQL.ProcedureParameter("_username", UserName);
                mySQL.ProcedureParameter("_password", UserPassword);
                mySQL.ProcedureParameter("_name", Name);
                mySQL.ProcedureParameter("_email", Email);
                mySQL.ProcedureParameter("_address", Address);
                mySQL.ProcedureParameter("_phone", PhoneNumber);
                mySQL.ProcedureParameter("_cash", Cash ?? "10000.0");
                return mySQL.ProceduteExecute();
            }

            return false;

        }

    }
}
