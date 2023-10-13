using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Road mainRoad = new Road(1000, 4, 2);
            TrafficSimulation simulation = new TrafficSimulation(mainRoad);

            Vehicle car1 = new Vehicle("Car", 60, 2);
            Vehicle truck1 = new Vehicle("Truck", 40, 3);
            Vehicle bus1 = new Vehicle("Bus", 50, 4);

            simulation.AddVehicle(car1);
            simulation.AddVehicle(truck1);
            simulation.AddVehicle(bus1);

            simulation.SimulateTraffic();
        }
    }
}