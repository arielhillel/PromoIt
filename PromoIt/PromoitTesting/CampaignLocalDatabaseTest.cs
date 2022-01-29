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

    public class CampaignLocalDatabaseTest
    {
        private MySQL mySQL = Configuration.MySQL;
        [Fact]
        public async Task Functions_MySQLUserRegisterLoginAsync()
        {
            Modes currentMode = Configuration.Mode;
            Modes currentLocalMode = Configuration.LocalMode;

            Configuration.Mode = Modes.Null;
            Configuration.LocalMode = Modes.Local;


            Campaign _campaign = new Campaign();
            _campaign.NonProfitUser = Configuration.CorrentUser;

            Users user = new Users();
            user.UserName = "n";    //awailable activist user!!!

            Campaign campaign = new Campaign();
            campaign.Name = "SomeCampaignNameTest";
            campaign.Hashtag = "SomeHashtagTest";
            campaign.Url = "SomeUrl";
            campaign.NonProfitUser = user;

            bool result2 = await _campaign.DeleteCampaignAsync();

            bool result1 = await campaign.SetNewCampaignAsync();

            Assert.True(result1, "Campaign Should Entered to Database");


            result2 = await _campaign.DeleteCampaignAsync();

            Assert.True(result2, "Campaign Should Deleted from Database");


            //return to set values
            Configuration.Mode = currentMode;
            Configuration.LocalMode = currentLocalMode;
        }

    }
}
