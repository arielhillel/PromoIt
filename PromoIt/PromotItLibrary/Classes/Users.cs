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

        public Users(Users user) 
        {
            UserName = user.UserName;
            UserPassword = user.UserPassword;
            UserType = user.UserType;
            Name = user.Name;
        }


        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }

        private static MySQL mySQL = Configuration.MySQL;
        private static Modes GlobalMode = Configuration.Mode;


        public Users Login(Modes mode = null)
        {

            if ((mode ?? Configuration.Mode) == Modes.MySQL)
            {
                Users user = null;
                mySQL.SetQuary("SELECT * FROM users where user_name=@username and user_password=@password limit 1");
                mySQL.QuaryParameter("@username", UserName);
                mySQL.QuaryParameter("@password", UserPassword);
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                if (results == null) throw new Exception($"no User Name {UserName}");
                while (results != null && results.Read())
                {
                    try
                    {
                        user = new Users();
                        user.UserName = results.GetString("user_name");
                        user.UserPassword = results.GetString("user_password");
                        user.UserType = results.GetString("user_type");
                        user.Name = results.GetString("name");
                    }
                    catch { throw new Exception($"error to set {UserName}"); };
                }
                return user;
            }

            return null;
        }

        public async Task<Users> LoginAsync(Modes mode = null)      //will not use!, only for testing
        {

            if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try
                { return await Functions.GetSingleDataRequest("SetUser", this); }
                catch { throw new Exception($"Functions error"); };
            }

            return Login(mode);
        }


    }
}
