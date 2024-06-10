using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ConcreteMediator: Mediator
    {
        private List<IStation> stations = new List<IStation>();

        public void AddStation(IStation station)
        {
            stations.Add(station);
        }

        public void SendMessage(string message, IStation sender)
        {
            foreach (IStation station in stations)
            {
                if (station != sender)
                {
                    station.ReceiveMessage(message);
                }
            }
        }
    }
}
