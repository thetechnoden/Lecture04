using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Road
    {
        public double Length { get; }
        public double Width { get; }
        public int Lanes { get; }
        public int TrafficLevel { get; set; }

        public Road(double length, double width, int lanes)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            TrafficLevel = 0;
        }
    }
}
