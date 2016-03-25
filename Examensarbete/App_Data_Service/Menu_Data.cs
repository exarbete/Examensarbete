using Examensarbete.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examensarbete.Application_Data
{
    public class Menu_Data
    {
        private static string DBConnectionString;
        private static SqlConnection sqlconnection;
        private readonly SqlCommand sqlcommand;
        public Menu_Data()
        {
            DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            sqlconnection = new SqlConnection(DBConnectionString);
            sqlcommand = new SqlCommand("Select * from Menu", sqlconnection);
            
        }
        public List<Menu> Menu_Data_Service()
        {
            List<Menu> listmenu = new List<Menu>();


            using (sqlconnection)
            {
                
                sqlconnection.Open();
                SqlDataReader rdr = sqlcommand.ExecuteReader();
                while (rdr.Read())
                {
                    Menu menu = new Menu();

                    menu.MenuID = Convert.ToInt32(rdr["MenuID"]);
                    menu.MenuName = rdr["MenuName"].ToString();
                    menu.Url = rdr["Url"].ToString();
                    menu.ParentID = Convert.ToInt32(rdr["ParentID"]);
                    listmenu.Add(menu);
                }
                sqlconnection.Close();
            }
            return listmenu;

        }
    }
}