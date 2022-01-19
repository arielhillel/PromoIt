using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Campaign
    {
        public string FirstProp { get; set; }
        public string SecondProp { get; set; }
        public string ThirdProp { get; set; }
        public string FourthProp { get; set; }

        public Campaign(string first, string second, string third, string fourth)
        {
            FirstProp = first;
            SecondProp = second;
            ThirdProp = third;
            FourthProp = fourth;
        }
    }
}
