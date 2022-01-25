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

        public string GetCash()
        {
            string str = "";
            mySQL.Quary("SELECT cash FROM promoit.users_activists Where user_name = @_username LIMIT 1");
            mySQL.ProcedureParameter("_username", UserName);
            using MySqlDataReader results = mySQL.GetQueryMultyResults();
            if (results == null) throw new Exception($"no cash {UserName}");
            if (results != null && results.Read())
            {
                try {  str = results.GetDecimal("cash").ToString() + "$"; }
                catch { throw new Exception($"error to get cash for {UserName}"); };
            }
            return str;
        }

        public async Task<bool> RegisterAsync(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.MySQL)
            {
                try { return (bool)await Functions.PostSingleDataRequest("SetUser", this); }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.Mode) == Modes.Functions)
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
