using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class MilitaryCar: Car
    {
        public bool hasWheels()
        {
            return true;
        }

        public bool hasWeapon()
        {
            return true;
        }
    }
}
