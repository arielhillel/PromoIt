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
        public AdminUser() : base() { }
        public AdminUser(int id, string userName, string userPassword, string name)
            : base(id, userName, userPassword, name) { }

        public bool Register(MySQL mySQL)
        {
            mySQL.Procedure("register_admin");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            return mySQL.ProceduteExecute();
        }
    }
}
