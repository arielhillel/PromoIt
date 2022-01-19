using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Classes;

namespace PromotItLibrary.Models
{
    public class Configuration
    {
        public static Users LoginUser { get; set; }
        public static MySQL MySql { get; set; }
        public static void MySQLStart() => MySql = new MySQL("localhost", "root", "admin", "promoit");

        ~Configuration() {  }
    }

}
