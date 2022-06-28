using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Salesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }//moje da vurne null
        public string Color { get; set; }
    }
}
