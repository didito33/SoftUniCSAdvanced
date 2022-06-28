using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Salesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int  Power { get; set; }
        public int? Displacement { get; set; }//int moje da ima null stoinost
        public string Efficiency { get; set; }
    }
}
