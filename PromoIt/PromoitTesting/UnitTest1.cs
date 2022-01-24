using PromotItLibrary.Classes;
using PromotItLibrary.Models;
using System;
using Xunit;

namespace PromoitTesting
{


    public class UnitTest1
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


            activistUser.Regiser();

            Users loggedInUser = user.Login();


            bool result =
                (loggedInUser.Name, loggedInUser.UserName, loggedInUser.UserPassword, loggedInUser.UserType)
                == (user.Name, user.UserName, user.UserPassword, user.UserType);

            //Delete For Next Test
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users_activists` WHERE (`user_name` = '{user.UserName}');");
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users` WHERE (`user_name` = '{user.UserName}');");

            Assert.True(result, "Random User Shoul Register and Login to the System");
        }


        [Fact]
        public void TrueTest()
        {
            Assert.True(true, "Result for regular Testing X Unit");
        }
    }
}
