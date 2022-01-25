using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Tweet
    {
        public Campaign Campaign { get; set; }
        public ActivistUser ActivistUser { get; set; }
        public string Cash { get; set; }
        public Tweet() 
        {
            Campaign = new Campaign();
            ActivistUser = new ActivistUser();
        }

    }
}
