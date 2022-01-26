﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class ProductDonated
    {
        public ProductDonated()
        {
            ProductInCampaign = new ProductInCampaign();
            ActivistUser = new ActivistUser(); //Configuration.CorrentUser ?? 
        }

        public ProductInCampaign ProductInCampaign { get; set; }
        public Users ActivistUser { get; set; }
        public string Quantity { get; set; }
        public string Shipped { get; set; }
        public string Id { get; set; }

        private MySQL mySQL = new MySQL();


        public async Task SetTwitterMessagTweet_SetBuyAnItemAsync()
        {
            try
            {
                await Functions.SetTwitterMessage_SetBuyAnItemAsync($"Product: {ProductInCampaign.Name}, Quantity {Quantity}" +
                    $"\nOrdered by Social Activist: @{ActivistUser.UserName}" +
                    $"\nFrom Business: {ProductInCampaign.BusinessUser.UserName}");
            }
            catch { }//Twitter exeption
        }


        public async Task<bool> SetBuyAnItemAsync(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try { return (bool)await Functions.PostSingleDataRequest("PromoitProductFunctions", this, "SetBuyAnItem"); }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("buy_a_product");
                mySQL.SetParameter("_product_id", ProductInCampaign.Id);
                mySQL.SetParameter("_quantity", int.Parse(Quantity));
                mySQL.SetParameter("_activist_user_name", ActivistUser.UserName);
                mySQL.SetParameter("_shipping", "not_shipped");
                return mySQL.ProceduteExecute();
            }

            return false;

        }

        public async Task<bool> SetProductShippingAsync(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.Functions)
            {
                try { return (bool)await Functions.PostSingleDataRequest("PromoitProductFunctions", this, "SetProductShipping"); }
                catch { throw new Exception($"Functions error"); };
            }

            else if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Quary("UPDATE `promoit`.`products_donated` SET `shipped` = @_shipping WHERE (`id2` = @_donated_product_id);");
                mySQL.SetParameter("_donated_product_id", Id);
                mySQL.SetParameter("_shipping", "shipped");
                return mySQL.ProceduteExecute();
            }
            
            return false;

        }

        public async Task<List<ProductDonated>> MySQL_GetDonatedProductForShipping_ListAsync(Modes mode = null)
        {
                if ((mode ?? Configuration.Mode) == Modes.Functions)
                {
                    try { return await Functions.GetMultipleDataRequest("PromoitProductFunctions", this, "GetDonatedProductForShipping"); }
                    catch { throw new Exception($"Functions error"); };
                }

                else if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
                {
                    // Error, no business user
                    if (ProductInCampaign.BusinessUser.UserType != "business" && ProductInCampaign.BusinessUser.UserName == null) throw new Exception("No set for business User");
                    mySQL.Quary(" SELECT * FROM products_in_campaign pic JOIN products_donated pd on pic.id = pd.product_in_campaign_id WHERE pd.shipped = @_shipped AND pic.business_user_name = @_business_user_name LIMIT @_limit"); //replace with mySQL.Procedure() //add LIMIT 20 ~
                    mySQL.ProcedureParameter("_shipped", "not_shipped");
                    mySQL.ProcedureParameter("_business_user_name", ProductInCampaign.BusinessUser.UserName);
                    mySQL.ProcedureParameter("_limit", 10);
                    using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();

                    List<ProductDonated> productDonatedList = new List<ProductDonated>();
                    while (results != null && results.Read())
                    {
                        try
                        {
                            ProductDonated productDonated = new ProductDonated();
                            productDonated.ActivistUser.UserName = results.GetString("activist_user_name");
                            productDonated.ProductInCampaign.Name = results.GetString("name");
                            productDonated.Id = results.GetString("id2");
                            productDonatedList.Add(productDonated);
                        }
                        catch { };
                    }
                    return productDonatedList;
                }

                return null;
        }


        public async Task<DataTable> GetDonatedProductForShipping_DataTableAsync()
        {
            DataTable dataTable = new DataTable();
            List<ProductDonated> productDonatedList = await MySQL_GetDonatedProductForShipping_ListAsync();
            foreach (string culmn in new[] { "clmnActivist", "clmnProduct", "clmnProductDonatedId" })
                dataTable.Columns.Add(culmn);
            foreach (ProductDonated productDonated in productDonatedList)
            {
                try
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["clmnActivist"] = productDonated.ActivistUser.UserName;
                    dataRow["clmnProduct"] = productDonated.ProductInCampaign.Name;
                    dataRow["clmnProductDonatedId"] = productDonated.Id;
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

    }
}
