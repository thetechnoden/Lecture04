using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class TrafficSimulation
    {
        private Road road;
        private List<Vehicle> vehicles;

        public TrafficSimulation(Road road)
        {
            this.road = road;
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void SimulateTraffic()
        {
            
        }
    }
}
