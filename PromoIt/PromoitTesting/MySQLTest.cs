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

    public class MySQLTest
    {
        private MySQL mySQL = Configuration.MySQL;
        [Fact]
        public async Task MySQLUserRegisterLoginAsync()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentDatabase = Configuration.DatabaseMode;
            Configuration.Mode = Modes.MySQL;
            Configuration.DatabaseMode = Modes.MySQL;
            
           Users user = new Users();
            user.Name = "testin11g Name For User";
            user.UserPassword = "1212asdasd";
            user.UserName = "fdg242fdggsdgs";
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
            Assert.True(result1, "User Should Register");

            Users loggedInUser = user.Login();

            bool result2 = loggedInUser != null;
            Assert.True(result2, "Login User Should Accepted");

            bool result3 =
                (loggedInUser.Name, loggedInUser.UserName, loggedInUser.UserPassword, loggedInUser.UserType)
                == (user.Name, user.UserName, user.UserPassword, user.UserType);

            //Delete For Next Test
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users_activists` WHERE (`user_name` = '{user.UserName}');");
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users` WHERE (`user_name` = '{user.UserName}');");

            Assert.True(result3, "Random User Shoul Register and Login to the System with same Values to Result");

            Configuration.Mode = currentMode;
            Configuration.DatabaseMode = currentDatabase;
        }


    }
}
