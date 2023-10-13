using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Vehicle : IDriveable
    {
        public string Type { get; }
        public double Speed { get; }
        public double Size { get; }

        public Vehicle(string type, double speed, double size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public void Move()
        {
           
        }

        public void Stop()
        {
           
        }
    }
}
