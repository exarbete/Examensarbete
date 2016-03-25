using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examensarbete.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
    }
}