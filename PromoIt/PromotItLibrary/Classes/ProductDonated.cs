using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class ProductDonated
    {
        public ProductInCampaign ProductInCampaign { get; set; }
        public Users ActivistUser { get; set; }
        public Campaign Campaign { get; set; }
        public string Quantity { get; set; }
        public string Shipped { get; set; }

        public ProductDonated()
        {
            ProductInCampaign = new ProductInCampaign();
            ActivistUser = new ActivistUser();
            Campaign = new Campaign();
        }
    }
}
