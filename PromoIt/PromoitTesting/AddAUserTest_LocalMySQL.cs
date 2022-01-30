using Moq;
using PromoitTesting.TestClasses;
using PromotItLibrary.Classes;
using PromotItLibrary.Interfaces;
using PromotItLibrary.Models;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace PromoitTesting
{


    public class AddAUserTest_LocalMySQL
    {
        private MySQL mySQL = Configuration.MySQL;


        public Users testUser() 
        {
            Users user = new Users();
            user.Name = "someNameForTest";
            user.UserPassword = "somePasswordForTest";
            user.UserName = "someUserNameForTest";
            user.UserType = "activist";
            return user;
        }

        public ActivistUser testActivistUser()
        {
            Users user = testUser();
            ActivistUser activistUser = new ActivistUser();
            activistUser.Name = user.Name;
            activistUser.UserPassword = user.UserPassword;
            activistUser.UserName = user.UserName;
            activistUser.UserType = user.UserType;
            activistUser.Email = "Email@some.com";
            activistUser.Address = "someAddress";
            activistUser.PhoneNumber = "4656456654";
            return activistUser;
        }

        [Fact]
        public async Task AddAUserTest_Local_MySQL()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentLocalMode = Configuration.LocalMode;
            Modes currentLocalDatabase = Configuration.DatabaseMode;
            Configuration.Mode = Modes.Null;
            Configuration.LocalMode = Modes.Local;
            Configuration.DatabaseMode = Modes.MySQL;


            Users user = testUser();
            ActivistUser activistUser = testActivistUser();

             //Try Delete First
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users_activists` WHERE (`user_name` = '{user.UserName}');");
            mySQL.QuaryExecute($"DELETE FROM `promoit`.`users` WHERE (`user_name` = '{user.UserName}');");

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

            //return to set values
            Configuration.Mode = currentMode;
            Configuration.LocalMode = currentLocalMode;
            Configuration.DatabaseMode = currentLocalDatabase;
        }

    }
}
