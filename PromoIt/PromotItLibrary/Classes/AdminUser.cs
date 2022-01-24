using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class AdminUser : Users
    {
        
        public AdminUser() : base() => UserType = "admin";

        private MySQL mySQL = Configuration.MySQL;

        public bool Register(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.MySQL)
                return MySQL_Register();
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return false;

            return false;

        }
        private bool MySQL_Register()
        {
            mySQL.Procedure("register_admin");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            return mySQL.ProceduteExecute();
        }
    }
}
