using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class ProductInCampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public Users BusinessUser { get; set; }
        public Campaign Campaign { get; set; }

        public ProductInCampaign()
        {
            Campaign = Configuration.CorrentCampaign ?? new Campaign();
            BusinessUser = Configuration.LoginUser ?? new Users();
        }

        private MySQL mySQL = Configuration.MySQL;





        public bool SetNewProduct()
        {
            mySQL.Quary("INSERT INTO `promoit`.`products_in_campaign` (`name`, `quantity`, `price`, `business_user_name`, `campaign_hashtag`) VALUES (@_name, @_quantity, @_price, @_business_user_name, @_campaign_hashtag);");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_quantity", decimal.Parse(Quantity));
            mySQL.SetParameter("_business_user_name", BusinessUser.UserName);
            mySQL.SetParameter("_price", int.Parse(Price));
            mySQL.SetParameter("_campaign_hashtag", Campaign.Hashtag);
            return mySQL.ProceduteExecute();
        }

        public MySqlDataAdapter GetList()
        {
            mySQL.SetQuary("SELECT * FROM products_in_campaign WHERE campaign_hashtag = @hashtag AND Quantity > 0");
            mySQL.QuaryParameter("@hashtag", Campaign.Hashtag);
            return mySQL.QuaryDataAdapter();
        }




        public MySqlDataAdapter GetListByHashtag(string hashtag)
        {
            mySQL.SetQuary("SELECT name, quantity, price FROM products WHERE campaign_hashtag  = @hashtag");
            mySQL.QuaryParameter("@hashtag", hashtag);
            return mySQL.QuaryDataAdapter();
        }
    }
}
