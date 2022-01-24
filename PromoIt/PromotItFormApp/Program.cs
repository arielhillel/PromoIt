using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromotItFormApp.LandingPages;
using PromotItLibrary.Classes;
using PromotItLibrary.Models;

namespace PromotItFormApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Users user = new Users();
            //user.UserName = "b";
            //user.UserType = "business";
            //user.UserType = "123";
            //user.UserName = "activist";
            //user.UserType = "activist";
            //Configuration.LoginUser = user;
            Application.Run(new PromotIt() );
        }
    }
}
