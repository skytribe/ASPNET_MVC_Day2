using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Day2_PassingData.Models
{
    public class ProductWithCategoryViewModel
    {
        // This type is from System.Web.MVC
        public SelectList Categories { get; set; }
        public Product Product { get; set; }
    }
}