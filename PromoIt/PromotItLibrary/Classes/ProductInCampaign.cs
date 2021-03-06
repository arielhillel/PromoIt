using MySql.Data.MySqlClient;
using PromotItLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class ProductInCampaign
    {
        public ProductInCampaign()
        {
            BusinessUser =  new Users();
            Campaign = new Campaign();
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

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitProductQueue, this, "SetNewProduct");
                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.PromoitProductFunctions, this, "SetNewProduct");
            }
            catch { return false; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
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
            if (productInCampaignList == null)
            {
                while ( Configuration.IsTries() )
                    return await GetList_DataTableAsync();
                Loggings.ErrorLog($"No Products in Get products in campagign, Campaign (#{Campaign.Hashtag}) by ({Configuration.CorrentUser.UserName})");
                Configuration.TriesReset();
                return dataTable;//no results
            }
            Configuration.TriesReset();

            foreach (ProductInCampaign productInCampaign in productInCampaignList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["clmnProductName"] = productInCampaign.Name;
                dataRow["clmnProductQuantity"] = productInCampaign.Quantity;
                dataRow["clmnProductPrice"] = productInCampaign.Price;
                dataRow["clmnProductId"] = productInCampaign.Id;    //hidden
                dataRow["clmnBusinessUser"] = productInCampaign.BusinessUser.UserName;    //hidden
                dataTable.Rows.Add(dataRow);
            }

            Loggings.ReportLog($"Get products in campagign, Campaign (#{Campaign.Hashtag}) by ({Configuration.CorrentUser.UserName})");

            return dataTable;
        }

        public async Task<List<ProductInCampaign>> MySQL_GetProductList_ListAsync(Modes mode = null) //for business and for activist
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitProductQueue, this, "GetProductList");
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return await Functions.GetMultipleDataRequest(Configuration.PromoitProductFunctions, this, "GetProductList");
            }
            catch { return null;};

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
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
