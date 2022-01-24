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
        public static Modes MySQL { get; }
        public static Modes CosmosDB { get; }
        public static Modes Functions { get; }
        public static Modes Queue { get; }

        public static Modes setDataBaseFor(Modes returnedMode, Modes modesDB) { Database = modesDB; return returnedMode; }
    }


}
