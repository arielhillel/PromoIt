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
        public BusinessUser BusinessUser { get; set; }
        public Campaign Campaign { get; set; }

        public string Campaign_Hashtag { get; set; } // fix
        
        public ProductInCampaign()
        {
            Campaign = new Campaign();
            BusinessUser = new BusinessUser();
        }

        private MySQL mySQL = Configuration.MySQL;

        public bool InsertNewProduct()
        {
            mySQL.Procedure("add_product");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_quantity", Quantity);
            mySQL.SetParameter("_price", Price);
            mySQL.SetParameter("_campaign_hashtag", Campaign_Hashtag);
            return mySQL.ProceduteExecute();
        }

        public MySqlDataAdapter DisplayAndSearch()
        {
            mySQL.SetQuary("SELECT name, quantity, price FROM products WHERE campaign_hashtag  = @hashtag");
            mySQL.QuaryParameter("@hashtag", Campaign_Hashtag);
            return mySQL.QuaryDataAdapter();
        }

        public MySqlDataAdapter DisplayAndSearchByHashtag (string hashtag)
        {
            mySQL.SetQuary("SELECT name, quantity, price FROM products WHERE campaign_hashtag  = @hashtag");
            mySQL.QuaryParameter("@hashtag", hashtag);
            return mySQL.QuaryDataAdapter();
        }
    }
}
