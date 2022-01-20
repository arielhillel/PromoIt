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
            mySQL.SetQuary("SELECT * FROM users where user_name=@username and user_password=@password limit 1");
            mySQL.QuaryParameter("@username", UserName);
            mySQL.QuaryParameter("@password", UserPassword);
            return mySQL.QuaryDataAdapter();
        }
    }
}
