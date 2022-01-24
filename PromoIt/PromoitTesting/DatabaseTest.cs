using Moq;
using PromoitTesting.TestClasses;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;
using PromotItLibrary.Models;
using System;
using Xunit;

namespace PromoitTesting
{


    public class DatabaseTest
    {
        private MySQL mySQL = Configuration.MySQL;
        [Fact]
        public void DataBaseUserRegisterLogin()
        {


            Users user = new Users();
            user.Name = "testing Name For User";
            user.UserPassword = "1212asdasd";
            user.UserName = "fdgfdggsdgs";
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


            bool result1 = activistUser.Register();
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
        }


    }
}
