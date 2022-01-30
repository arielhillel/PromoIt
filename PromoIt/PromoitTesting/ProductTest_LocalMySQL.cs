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


    public class ProductTest_LocalMySQL
    {

        private MySQL mySQL = Configuration.MySQL;

        public ProductInCampaign testingProductInCampaign() 
        {

            ProductInCampaign productInCampaign = new ProductInCampaign();
            productInCampaign.Name = "SomeTestedName";
            productInCampaign.Quantity = "45";
            productInCampaign.BusinessUser.UserName = "b";      //Awailable User
            productInCampaign.Price = "45";
            productInCampaign.Campaign.Hashtag = "nisayon";      //Awailable  Hashtag
            return productInCampaign;
        }


        [Fact]
        public async Task Functions_MySQLUserRegisterLoginAsync()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentLocalMode = Configuration.LocalMode;
            Modes currentLocalDatabase = Configuration.DatabaseMode;
            Configuration.Mode = Modes.Null;
            Configuration.LocalMode = Modes.Local;
            Configuration.DatabaseMode = Modes.MySQL;


            ProductInCampaign productInCampaign = testingProductInCampaign();

            bool result1 = await productInCampaign.SetNewProductAsync();

            Assert.True(result1, "Campaign Should Entered to Database");

            mySQL.QuaryExecute($"DELETE FROM `promoit`.`products_in_campaign` WHERE(`name` = '{productInCampaign.Name}');");

            //return to set values
            Configuration.Mode = currentMode;
            Configuration.LocalMode = currentLocalMode;
            Configuration.DatabaseMode = currentLocalDatabase;
        }

    }
}
