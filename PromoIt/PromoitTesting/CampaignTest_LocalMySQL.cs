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


    public class CampaignTest_LocalMySQL
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
        public async Task CampaignTest_Local_MySQL()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentLocalMode = Configuration.LocalMode;
            Modes currentLocalDatabase = Configuration.DatabaseMode;
            Configuration.Mode = Modes.Null;
            Configuration.LocalMode = Modes.Local;
            Configuration.DatabaseMode = Modes.MySQL;


            Campaign campaign = testingCampaign();


            await campaign.DeleteCampaignAsync();


            bool result1 = await campaign.SetNewCampaignAsync();

            Assert.True(result1, "Campaign Should Entered to Database");


            bool result2 = await campaign.DeleteCampaignAsync();

            Assert.True(result2, "Campaign Should Deleted from Database");


            //return to set values
            Configuration.Mode = currentMode;
            Configuration.LocalMode = currentLocalMode;
            Configuration.DatabaseMode = currentLocalDatabase;
        }

    }
}
