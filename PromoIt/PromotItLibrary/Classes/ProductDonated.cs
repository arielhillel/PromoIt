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
    public class ProductDonated
    {
        public ProductInCampaign ProductInCampaign { get; set; }
        public Users ActivistUser { get; set; }
        public string Quantity { get; set; }
        public string Shipped { get; set; }
        public string Id { get; set; }

        public ProductDonated()
        {
            ProductInCampaign = new ProductInCampaign();

            ActivistUser = Configuration.LoginUser ?? new ActivistUser();
        }

        private MySQL mySQL = new MySQL();

        public bool SetBuyAnItem()
        {
            mySQL.Procedure("buy_a_product"); 
            mySQL.SetParameter("_product_id", ProductInCampaign.Id);
            mySQL.SetParameter("_quantity", int.Parse(Quantity));
            mySQL.SetParameter("_activist_user_name", ActivistUser.UserName);
            mySQL.SetParameter("_shipping", "not_shipped");
            return mySQL.ProceduteExecute();
        }


        public bool SetProductShipping()
        {
            mySQL.Quary("UPDATE `promoit`.`products_donated` SET `shipped` = @_shipping WHERE (`id2` = @_donated_product_id);");
            mySQL.SetParameter("_donated_product_id", Id);
            mySQL.SetParameter("_shipping", "shipped");
            return mySQL.ProceduteExecute();
        }



        public List<ProductDonated> MySQL_GetDonatedProductForShipping_List()
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
                    productDonated.ActivistUser.UserName = results.GetValue("activist_user_name").ToString();
                    productDonated.ProductInCampaign.Name = results.GetValue("name").ToString();
                    productDonated.Id = results.GetValue("id2").ToString();
                    productDonatedList.Add(productDonated);
                }
                catch { };
            }
            return productDonatedList;
        }


        public DataTable GetDonatedProductForShipping_DataTable()
        {
            DataTable dataTable = new DataTable();
            List<ProductDonated> productDonatedList = MySQL_GetDonatedProductForShipping_List();
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
