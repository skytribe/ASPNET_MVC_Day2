using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVC_Day2_PassingData.Models
{
    public class ProductViewModel
    {
        public IList<Product> Products { get; set; }

        public string DisplayColor(bool OnSale)
        {
            string retVal = "white";
            if (OnSale) retVal = "lightgreen";
            return retVal;

        }
    }
}