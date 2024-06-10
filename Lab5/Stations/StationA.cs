using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class StationA : IStation
    {
        private Mediator mediator;
        private string name;

        public StationA(string name, Mediator mediator)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            mediator.SendMessage($"[{name}]: {message}", this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} received: {message}");
        }
    }
}
