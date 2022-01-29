using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using PromotItLibrary.Models;

namespace PromotItLibrary.Classes
{
    public class AdminUser : Users
    {
        public AdminUser() : base() => UserType = "admin";

        private static MySQL mySQL = Configuration.MySQL;

        public async Task<bool> RegisterAsync(Modes mode = null)
        {

            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.SetUserQueue, this, "");
                else if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return (bool)await Functions.PostSingleDataInsert(Configuration.SetUserFunctions, this, "");
            }
            catch {  return false; }

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Procedure("register_admin");
                mySQL.SetParameter("_name", Name);
                mySQL.SetParameter("_username", UserName);
                mySQL.SetParameter("_password", UserPassword);
                return mySQL.ProceduteExecute();
            }

            return false;

        }


        public async Task<DataTable> GetAllCampaignsAdmin_DataTableAsync()
        {
            DataTable dataTable = new DataTable();
            Campaign campaign1 = new Campaign();
            List<Campaign> campaignsList = await campaign1.MySQL_GetAllCampaigns_ListAsync();       //From Campaign Class
            foreach (string culmn in new[] { "Hashtag", "Webpage", "Creator" })
                dataTable.Columns.Add(culmn);

            if (campaignsList == null)
            {
                while (Configuration.IsTries())
                    return await GetAllCampaignsAdmin_DataTableAsync();
                Loggings.ErrorLog($"Admin Requested to get all campaigns list, The list is empty, Reguested by ({UserName})");
                Configuration.TriesReset();
                return dataTable;//no results
            }
            Configuration.TriesReset();

            Loggings.CampaignsLog.LogInformation($"Campaign List, Reguested by ({UserName})");
            foreach (Campaign campaign in campaignsList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Hashtag"] = campaign.Hashtag;
                dataRow["Webpage"] = campaign.Url;
                dataRow["Creator"] = campaign.NonProfitUser.UserName;
                dataTable.Rows.Add(dataRow);
                Loggings.CampaignsLog.LogInformation($"Campaign Hashtag (#{campaign.Hashtag}) Creator ({campaign.NonProfitUser.UserName}) Webpage ({campaign.Url})");
            }
            Loggings.CampaignsLog.LogInformation($"Report end");

            Loggings.ReportLog($"Admin Requested to get all campaigns list, Reguested by ({UserName})");

            return dataTable;

        }

        public async Task<List<Users>> MySQL_GetAllUsers_ListAsync(Modes mode = null)
        {
            try
            {   //Queue and Functions
                if ((mode ?? Configuration.Mode) == Modes.Queue)
                    return await Functions.GetMultipleDataRequest(Configuration.SetUserQueue, new Users(), "GetAllUsers");
                if ((mode ?? Configuration.Mode) == Modes.Functions)
                    return await Functions.GetMultipleDataRequest(Configuration.SetUserFunctions, new Users(), "GetAllUsers");
            } catch { return null;}

            if ((mode ?? Configuration.DatabaseMode) == Modes.MySQL)
            {
                mySQL.Quary("SELECT name,user_name,user_type FROM users");
                using MySqlDataReader results = mySQL.ProceduteExecuteMultyResults();
                List<Users> userList = new List<Users>();
                while (results != null && results.Read()) //for 1 result: if (mdr.Read())
                {
                    try
                    {
                        Users user = new Users();
                        user.Name = results.GetString("name");
                        user.UserName = results.GetString("user_name");
                        user.UserType = results.GetString("user_type");
                        userList.Add(user);
                    }
                    catch { };
                }
                return userList;
            }
            return null;
        }

        public async Task<DataTable> GetAllUsers_DataTableAsync()
        {
            DataTable dataTable = new DataTable();
            List<Users> userList = await MySQL_GetAllUsers_ListAsync();
            foreach (string culmn in new[] { "Name", "UserName", "Type" })
                dataTable.Columns.Add(culmn);

            if (userList == null)
            {
                while (Configuration.IsTries())
                    return await GetAllUsers_DataTableAsync();
                Loggings.ErrorLog($"Admin Requested to get all users list, The list is empty, Reguested by ({UserName})");
                Configuration.TriesReset();
                return dataTable;//no results
            }
            Configuration.TriesReset();

            Loggings.UsersLog.LogInformation($"Users List, Reguested by ({UserName})");
            foreach (Users user in userList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Name"] = user.Name;
                dataRow["UserName"] = user.UserName;
                dataRow["Type"] = user.UserType;
                dataTable.Rows.Add(dataRow);
                Loggings.UsersLog.LogInformation($"User UserName (#{user.UserName}) Name ({user.Name}) Type ({user.UserType})");
            }
            Loggings.UsersLog.LogInformation($"Report end");

            Loggings.ReportLog($"Admin Requested to get all users list, Reguested by ({UserName})");

            return dataTable;

        }

    }
}
