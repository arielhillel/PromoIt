using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class ActivistUser : Users
    {
        public ActivistUser() : base() =>  UserType = "activist";

        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Cash { get; set; }
        private MySQL mySQL = Configuration.MySQL;

        public bool Regiser() 
        {
            mySQL.Procedure("register_activist");
            mySQL.ProcedureParameter("_username", UserName);
            mySQL.ProcedureParameter("_password", UserPassword);
            mySQL.ProcedureParameter("_name", Name);
            mySQL.ProcedureParameter("_email", Email);
            mySQL.ProcedureParameter("_address", Address);
            mySQL.ProcedureParameter("_phone", PhoneNumber);
            mySQL.ProcedureParameter("_cash", 10000.0);
            return mySQL.ProceduteExecute();
        }
    }
}
