using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotItLibrary.Classes
{
    public class Modes
    {
        public static Modes Database { get; private set; } = MySQL; //Defult
        public static Modes MySQL { get; } = new Modes();
        public static Modes CosmosDB { get; } = new Modes();
        public static Modes Functions { get; } = new Modes();
        public static Modes Queue { get; } = new Modes();

    }


}
