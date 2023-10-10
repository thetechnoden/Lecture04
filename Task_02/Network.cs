using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Network
    {
        private List<IConnectable> devices = new List<IConnectable>();

        public void AddDevice(IConnectable device)
        {
            devices.Add(device);
        }

        public void ConnectDevices()
        {
            foreach (var device1 in devices)
            {
                foreach (var device2 in devices)
                {
                    if (device1 != device2)
                    {
                        device1.Connect(device2);
                    }
                }
            }
        }

        public void DisconnectDevices()
        {
            foreach (var device1 in devices)
            {
                foreach (var device2 in devices)
                {
                    if (device1 != device2)
                    {
                        device1.Disconnect();
                    }
                }
            }
        }
    }

}
