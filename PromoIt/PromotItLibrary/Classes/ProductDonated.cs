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


    }
}
