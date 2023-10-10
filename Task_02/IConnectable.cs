using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    interface IConnectable
    {
        void Connect(IConnectable device); 
        void Disconnect(); 
        void SendData(string data); 
        void ReceiveData(string data); 
    }
}
