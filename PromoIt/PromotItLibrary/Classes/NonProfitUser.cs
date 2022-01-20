using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class NonProfitUser : Users
    {
        public NonProfitUser() : base() { }
        public NonProfitUser(int id, string userName, string userPassword, string name, string Email)
            : base(id, userName, userPassword, name) { }

        public string Email { get; set; }
        public string WebSite { get; set; }

        public bool Register(MySQL mySQL) 
        {
            mySQL.Procedure("register_non_profit");
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_email", Email);
            mySQL.SetParameter("_website", WebSite);
            return mySQL.ProceduteExecute();
        }
    }
}
