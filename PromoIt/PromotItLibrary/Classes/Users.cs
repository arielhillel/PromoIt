using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;
using PromotItLibrary.Interfaces;

namespace PromotItLibrary.Classes
{
    public class Users : IUsers
    {
        public Users() { }
        public Users(int id, string userName, string userPassword, string name)
            : this()
            => (Id, UserName, UserPassword, Name) = (id, userName, userPassword, name);

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }



        public MySqlDataAdapter Login(MySQL mySQL)
        {
            mySQL.SetQuary($"select * from( select admin_user_name as Username, admin_password as Password, type from admin_register union select sa_user_name, sa_password, type from social_activist_register union select npo_user_name, npo_password, type from non_profit_organization_register union select bcr_user_name, bcr_password, type from business_company_register) as u WHERE u.Username = @username and u.Password = @password LIMIT 1");
            mySQL.QuaryParameter("@username", UserName);
            mySQL.QuaryParameter("@password", UserPassword);
            return mySQL.QuaryDataAdapter();
        }
    }
}
