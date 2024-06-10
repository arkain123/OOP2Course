using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal interface IStation
    {
        public void SendMessage(string message);
        public void ReceiveMessage(string message);
    }
}
