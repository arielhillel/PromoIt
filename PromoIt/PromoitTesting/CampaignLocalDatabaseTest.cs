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


    public class CampaignLocalDatabaseTest
    {

        public Campaign testingCampaign() 
        {

            Campaign campaign = new Campaign();
            campaign.Name = "SomeCampaignNameTest6";
            campaign.Hashtag = "SomeHashtagTest";
            campaign.Url = "SomeUrl";
            campaign.NonProfitUser.UserName = "n";    //awailable activist user!!!

            return campaign;
        }



        [Fact]
        public async Task Functions_MySQLUserRegisterLoginAsync()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentLocalMode = Configuration.LocalMode;

            Configuration.Mode = Modes.Null;
            Configuration.LocalMode = Modes.Local;

            Campaign campaign = testingCampaign();


            bool result2 = await campaign.DeleteCampaignAsync();


            Thread.Sleep(1000 );

            bool result1 = await campaign.SetNewCampaignAsync();

            Assert.True(result1, "Campaign Should Entered to Database");


            Thread.Sleep(1000);

            bool result3 = await campaign.DeleteCampaignAsync();

            Assert.True(result3, "Campaign Should Deleted from Database");


            //return to set values
            Configuration.Mode = currentMode;
            Configuration.LocalMode = currentLocalMode;
        }

    }
}
