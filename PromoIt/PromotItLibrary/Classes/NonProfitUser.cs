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
            mySQL.Procedure("insert_new_npo");
            mySQL.SetParameter("p_organization_name", Name);
            mySQL.SetParameter("p_npo_user_name", UserName);
            mySQL.SetParameter("p_npo_password", UserPassword);
            mySQL.SetParameter("p_npo_email", Email);
            mySQL.SetParameter("p_website_url", WebSite);
            return mySQL.ProceduteExecute();
        }
    }
}
