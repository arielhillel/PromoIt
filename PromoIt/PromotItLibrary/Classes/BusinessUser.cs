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
        public BusinessUser() : base() { }
        public BusinessUser(int id, string userName, string userPassword, string name)
            : base(id, userName, userPassword, name) { }

        public bool Register(MySQL mySQL) 
        {
            mySQL.Procedure("insert_new_bcr");
            mySQL.SetParameter("p_company_name", Name);
            mySQL.SetParameter("p_bcr_user_name", UserName);
            mySQL.SetParameter("p_bcr_password", UserPassword);
            return mySQL.ProceduteExecute();
        }

    }
}
