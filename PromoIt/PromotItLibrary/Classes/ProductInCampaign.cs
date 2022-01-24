using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        private static MySQL mySQL = Configuration.MySQL;

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

        public DataTable GetList() //for business and for activist
        {
            if (Campaign.Hashtag == null ) throw new Exception("No set for Campaign Hashtag");
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "clmnProductId", "clmnProductName", "clmnProductQuantity", "clmnProductPrice" })
                dataTable.Columns.Add(culmn);
            mySQL.SetQuary("SELECT * FROM products_in_campaign WHERE campaign_hashtag = @hashtag AND Quantity > 0");
            mySQL.QuaryParameter("@hashtag", Campaign.Hashtag);
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read())
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("clmnProductId", "id"), ("clmnProductName", "name"), ("clmnProductQuantity", "quantity"), ("clmnProductPrice", "price") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

    }
}
