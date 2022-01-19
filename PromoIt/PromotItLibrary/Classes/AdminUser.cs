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
            mySQL.Procedure("insert_new_admin");
            mySQL.SetParameter("p_admin_full_name", Name);
            mySQL.SetParameter("p_admin_user_name", UserName);
            mySQL.SetParameter("p_admin_password", UserPassword);
            return mySQL.ProceduteExecute();
        }
    }
}
