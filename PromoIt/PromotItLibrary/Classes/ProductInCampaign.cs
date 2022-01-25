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
        public ProductInCampaign()
        {
            BusinessUser = Configuration.LoginUser ?? new Users();
            Campaign = Configuration.CorrentCampaign ?? new Campaign();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public Users BusinessUser { get; set; }
        public Campaign Campaign { get; set; }


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

        public DataTable GetList_DataTable() //for business and for activist
        {
            DataTable dataTable = new DataTable();
            List<ProductInCampaign> productInCampaignList = MySQL_GetList_List();
            foreach (string culmn in new[] { "clmnProductId", "clmnProductName", "clmnProductQuantity", "clmnProductPrice" })
                dataTable.Columns.Add(culmn);
            foreach (ProductInCampaign productInCampaign in productInCampaignList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnProductId"] = productInCampaign.Id;
                    dataRow["clmnProductName"] = productInCampaign.Name;
                    dataRow["clmnProductQuantity"] = productInCampaign.Quantity;
                    dataRow["clmnProductPrice"] = productInCampaign.Price;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

        public List<ProductInCampaign> MySQL_GetList_List() //for business and for activist
        {
            if (Campaign.Hashtag == null ) throw new Exception("No set for Campaign Hashtag");
            mySQL.SetQuary("SELECT * FROM products_in_campaign WHERE campaign_hashtag = @hashtag AND Quantity > 0");
            mySQL.QuaryParameter("@hashtag", Campaign.Hashtag);
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();

            List<ProductInCampaign> productInCampaignList = new List<ProductInCampaign>();
            while (results != null && results.Read())
            {
                try
                {
                    ProductInCampaign productInCampaign = new ProductInCampaign();
                    productInCampaign.Id = results.GetValue("id").ToString();
                    productInCampaign.Name = results.GetValue("name").ToString();
                    productInCampaign.Quantity = results.GetValue("quantity").ToString();
                    productInCampaign.Price = results.GetValue("price").ToString();
                    productInCampaignList.Add(productInCampaign);
                }
                catch { };
            }
            return productInCampaignList;
        }

    }
}
