using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Client
    {
        ClientInterface itarget;

        public Client(ClientInterface ITarget)
        {
            itarget = ITarget;
        }

        public void ValuesOut(int intValue, double doubleValue, char charValue)
        {
            Console.Write("Результат работы ClientDouble: ");
            itarget.ClientDouble(doubleValue);
            Console.WriteLine();
            Console.Write("Результат работы ClientInt: ");
            itarget.ClientInt(intValue);
            Console.WriteLine();
            Console.Write("Результат работы ClientChar: ");
            itarget.ClientChar(charValue);
            Console.WriteLine();
        }
    }
}
