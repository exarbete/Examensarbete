using Examensarbete.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examensarbete.App_Data_Service
{
    public class SubCategory_Data
    {
        // private static string DBConnectionString;
        //private static SqlConnection sqlconnection;
        //private static SqlCommand sqlcommand;
        public SubCategory_Data()
        {
            
        }
        public List<SubCategory> SubCategory_Data_Service()
        {
            List<SubCategory> listsubcategory = new List<SubCategory>();
            string DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            SqlConnection sqlconnection = new SqlConnection(DBConnectionString);
            SqlCommand sqlcommand = new SqlCommand("SubCategory_SP", sqlconnection);

            using (sqlconnection)
            {
                
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlconnection.Open();
                SqlDataReader rdr = sqlcommand.ExecuteReader();
                
                while (rdr.Read())
                {
                    SubCategory subcategory = new SubCategory();

                    subcategory.SubCategoryID = Convert.ToInt32(rdr["SubCategoryID"]);
                    subcategory.SubCategoryName = rdr["SubCategoryName"].ToString();
                    subcategory.CategoryName = rdr["CategoryName"].ToString();
                    subcategory.CategoryID = Convert.ToInt32(rdr["CategoryID"]);
                    listsubcategory.Add(subcategory);
                }
                sqlconnection.Close();
            }
               
            return listsubcategory;
        }
    }
}