using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examensarbete.Models;
using Examensarbete.Application_Data;
using Examensarbete.App_Data_Service;

namespace Examensarbete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }


        public JsonResult GetMenu_Data()
        {

            Menu_Data menudata = new Menu_Data();
            var listmenu = menudata.Menu_Data_Service();
            return new JsonResult { Data = listmenu, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }

        public JsonResult GetSubCategory_Data()
        {

            SubCategory_Data subcategorydata = new SubCategory_Data();
            var listsubcategory = subcategorydata.SubCategory_Data_Service();
            return new JsonResult { Data = listsubcategory, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }



    }
}
