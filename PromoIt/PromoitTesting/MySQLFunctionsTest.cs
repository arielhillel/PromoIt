using Moq;
using PromoitTesting.TestClasses;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;
using PromotItLibrary.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PromoitTesting
{

    public class MySQLFunctionsTest
    {
        private MySQL mySQL = Configuration.MySQL;
        [Fact]
        public async Task Functions_MySQLUserRegisterLoginAsync()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentDatabase = Configuration.DatabaseMode;
            Configuration.Mode = Modes.Functions;
            Configuration.DatabaseMode = Modes.MySQL;
            
           Users user = new Users();
            user.Name = "testin45g Name For User";
            user.UserPassword = "1212asdasd";
            user.UserName = "fdgfdgg4544sdgs";
            user.UserType = "activist";
                //Try Delete First
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users_activists` WHERE (`user_name` = '{user.UserName}');");
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users` WHERE (`user_name` = '{user.UserName}');");


            ActivistUser activistUser = new ActivistUser();
            activistUser.Name = user.Name;
            activistUser.UserPassword = user.UserPassword;
            activistUser.UserName = user.UserName;
            activistUser.UserType = user.UserType;
            activistUser.Email = "SDFAS@dfGDF";
            activistUser.Address = "GDSGDSGD";
            activistUser.PhoneNumber = "FDGDFGD";


            bool result1 = await activistUser.RegisterAsync();
            Assert.True(result1, "User Should Register / Function Mast Be Activated!");

            Users loggedInUser = await user.LoginAsync();

            bool result2 = loggedInUser != null;
            Assert.True(result2, "Login User Should Accepted / Function Mast Be Activated");

            bool result3 =
                (loggedInUser.Name, loggedInUser.UserName, loggedInUser.UserPassword, loggedInUser.UserType)
                == (user.Name, user.UserName, user.UserPassword, user.UserType);

            //Delete For Next Test
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users_activists` WHERE (`user_name` = '{user.UserName}');");
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users` WHERE (`user_name` = '{user.UserName}');");

            Assert.True(result3, "Random User Shoul Register and Login to the System with same Values to Result / Function Mast Be Activated");

            Configuration.Mode = currentMode;
            Configuration.DatabaseMode = currentDatabase;
        }


    }
}
