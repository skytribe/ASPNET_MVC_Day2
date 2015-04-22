using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcWebApp.Models
{
    public class Calculator
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }


        public void Add()
        {
            try
            {
                Result = Value1 + Value2;
            }
            catch
            {
                Result = 0;
            }
        }


        public int Result { get; set; }
    }
}