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
            BusinessUser =  new Users();    // Configuration.CorrentUser ??
            Campaign = new Campaign();    //Configuration.CorrentCampaign ?? 
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public Users BusinessUser { get; set; }
        public Campaign Campaign { get; set; }


        private static MySQL mySQL = Configuration.MySQL;

        public async Task<bool> SetNewProductAsync(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try 
                {
                    return (bool)await Functions.PostSingleDataRequest("PromoitProductFunctions", this, "SetNewProduct");
                }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Quary("INSERT INTO `promoit`.`products_in_campaign` (`name`, `quantity`, `price`, `business_user_name`, `campaign_hashtag`) VALUES (@_name, @_quantity, @_price, @_business_user_name, @_campaign_hashtag);");
                mySQL.SetParameter("_name", Name);
                mySQL.SetParameter("_quantity", decimal.Parse(Quantity));
                mySQL.SetParameter("_business_user_name", BusinessUser.UserName);
                mySQL.SetParameter("_price", int.Parse(Price));
                mySQL.SetParameter("_campaign_hashtag", Campaign.Hashtag);
                return mySQL.ProceduteExecute();
            }

            return false;

        }

        public async Task<DataTable> GetList_DataTableAsync() //for business and for activist
        {
            DataTable dataTable = new DataTable();
            List<ProductInCampaign> productInCampaignList = await MySQL_GetProductList_ListAsync();
            foreach (string culmn in new[] { "clmnProductId", "clmnBusinessUser", "clmnProductName", "clmnProductQuantity", "clmnProductPrice" })
                dataTable.Columns.Add(culmn);
            foreach (ProductInCampaign productInCampaign in productInCampaignList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnProductName"] = productInCampaign.Name;
                    dataRow["clmnProductQuantity"] = productInCampaign.Quantity;
                    dataRow["clmnProductPrice"] = productInCampaign.Price;

                    dataRow["clmnProductId"] = productInCampaign.Id;
                    dataRow["clmnBusinessUser"] = productInCampaign.BusinessUser.UserName;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

        public async Task<List<ProductInCampaign>> MySQL_GetProductList_ListAsync(Modes mode = null) //for business and for activist
        {
            if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try { return await Functions.GetMultipleDataRequest("PromoitProductFunctions", this, "GetProductList"); }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {

                if (Campaign.Hashtag == null) throw new Exception("No set for Campaign Hashtag");
                mySQL.SetQuary("SELECT * FROM products_in_campaign WHERE campaign_hashtag = @hashtag AND Quantity > 0");
                mySQL.QuaryParameter("@hashtag", Campaign.Hashtag);
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();

                List<ProductInCampaign> productInCampaignList = new List<ProductInCampaign>();
                while (results != null && results.Read())
                {
                    try
                    {
                        ProductInCampaign productInCampaign = new ProductInCampaign();
                        productInCampaign.Name = results.GetString("name");
                        productInCampaign.Quantity = results.GetString("quantity");
                        productInCampaign.Price = results.GetString("price");

                        productInCampaign.Id = results.GetString("id");
                        productInCampaign.BusinessUser.UserName = results.GetString("business_user_name");
                        productInCampaignList.Add(productInCampaign);
                    }
                    catch { };
                }
                return productInCampaignList;
            }

            return null;

        }

    }
}
