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
        public BusinessUser(int id, string userName, string userPassword, string name)
            : base(id, userName, userPassword, name) { }

        public bool Register(MySQL mySQL) 
        {
            mySQL.Procedure("register_business");
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            mySQL.SetParameter("_name", Name);
            return mySQL.ProceduteExecute();
        }

    }
}
