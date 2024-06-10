using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator CommunicationCenter = new ConcreteMediator();

            IStation station1 = new StationA("East Station", CommunicationCenter);
            IStation station2 = new StationA("West Station", CommunicationCenter);
            IStation station3 = new StationA("South Station", CommunicationCenter);
            IStation station4 = new StationA("North Station", CommunicationCenter);

            CommunicationCenter.AddStation(station1);
            CommunicationCenter.AddStation(station2);
            CommunicationCenter.AddStation(station3);
            CommunicationCenter.AddStation(station4);

            station1.SendMessage("Hello from East");
            station2.SendMessage("Hello from West");
        }
    }
}
