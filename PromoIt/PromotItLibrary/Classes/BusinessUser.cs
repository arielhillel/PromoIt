﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class BusinessUser : Users
    {
        public BusinessUser() : base() => UserType = "business";

        public bool Register(Modes mode = null)
        {
            if ((mode ?? Configuration.Mode) == Modes.MySQL)
                return MySQL_Register();
            else if ((mode ?? Configuration.Mode) == Modes.Functions)
                return false;

            return false;

        }

        private bool MySQL_Register() 
        {
            MySQL mySQL = Configuration.MySQL;
            mySQL.Procedure("register_business");
            mySQL.SetParameter("_username", UserName);
            mySQL.SetParameter("_password", UserPassword);
            mySQL.SetParameter("_name", Name);
            return mySQL.ProceduteExecute();
        }

    }
}
