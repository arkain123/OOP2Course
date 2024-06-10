using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Adapter : Original, ClientInterface
    {

        public void ClientDouble(double value)
        {
            OriginalDouble(value);
        }

        public void ClientInt(int value)
        {
            OriginalInt(value * 2);
        }

        public void ClientChar(char value)
        {
            for (int i = 0; i < 5; i++)
            {
                OriginalChar(value);
            }
        }
    }
}
