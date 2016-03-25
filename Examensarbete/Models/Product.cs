using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examensarbete.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public int SubCategoryID { get; set; }
    }
}