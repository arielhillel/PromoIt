using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class ActivistUser : Users
    {
        public ActivistUser() : base() { }
        public ActivistUser(int id, string userName, string userPassword, string name)
            : base(id, userName, userPassword, name) { }

        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public bool Regiser(MySQL mySQL) 
        {
            mySQL.Procedure("insert_new_sa");
            mySQL.ProcedureParameter("p_sa_full_name", Name);
            mySQL.ProcedureParameter("p_sa_user_name", UserName);
            mySQL.ProcedureParameter("p_sa_password", UserPassword);
            mySQL.ProcedureParameter("p_sa_email", Email);
            mySQL.ProcedureParameter("p_sa_address", Address);
            mySQL.ProcedureParameter("p_sa_phone_number", PhoneNumber);
            return mySQL.ProceduteExecute();
        }
    }
}
