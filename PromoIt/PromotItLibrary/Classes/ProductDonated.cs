﻿using MySql.Data.MySqlClient;
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

        public ProductDonated()
        {
            ProductInCampaign = new ProductInCampaign();

            ActivistUser = Configuration.LoginUser ?? new ActivistUser();
        }

        private MySQL mySQL = new MySQL();

        public DataTable ShowDonatedProductForShipping()
        {
            // Error, no npo user
            if (ProductInCampaign.BusinessUser.UserType != "business" && ProductInCampaign.BusinessUser.UserName == null) throw new Exception("No set for npo User");
            DataTable dataTable = new DataTable();
            // Creating the same Grid clmns on the table
            foreach (string culmn in new[] { "clmnActivist", "clmnProduct" })
                dataTable.Columns.Add(culmn);
            //mySQL.Procedute("getstudents");
            mySQL.Quary(" SELECT* FROM products_in_campaign pic JOIN products_donated pd on pic.id = pd.product_in_campaign_id WHERE shipped = @_shipped AND pic.business_user_name = @_business_user_name"); //replace with mySQL.Procedure() //add LIMIT 20 ~
            mySQL.ProcedureParameter("_shipped", "not_shipped");
            mySQL.ProcedureParameter("_business_user_name", ProductInCampaign.BusinessUser.UserName);
            using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    DataRow? dataRow = dataTable.NewRow();
                    foreach (var (key, value) in new[] { ("clmnActivist", "activist_user_name"), ("clmnProduct", "name") })
                        dataRow[key] = results.GetValue(value);
                    dataTable.Rows.Add(dataRow);
                }
                catch { };
            }
            return dataTable;
        }

    }
}
