using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Product
    {
       
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

        public string Campaign_Hashtag { get; set; }

        public bool InsertNewProduct(MySQL mySQL)
        {
            mySQL.Procedure("add_product");
            mySQL.SetParameter("_name", Name);
            mySQL.SetParameter("_quantity", Quantity);
            mySQL.SetParameter("_price", Price);
            mySQL.SetParameter("_campaign_hashtag", Campaign_Hashtag);
            return mySQL.ProceduteExecute();
        }

        public MySqlDataAdapter DisplayAndSearch(MySQL mySQL)
        {
            mySQL.SetQuary("SELECT name, quantity, price FROM products WHERE campaign_hashtag  = @hashtag");
            mySQL.QuaryParameter("@hashtag", Campaign_Hashtag);
            return mySQL.QuaryDataAdapter();
        }

        public MySqlDataAdapter DisplayAndSearchByHashtag (MySQL mySQL, string hashtag)
        {
            mySQL.SetQuary("SELECT name, quantity, price FROM products WHERE campaign_hashtag  = @hashtag");
            mySQL.QuaryParameter("@hashtag", hashtag);
            return mySQL.QuaryDataAdapter();
        }
    }
}
