using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class MilitaryPlane: Plane
    {
        public bool hasWings()
        {
            return true;
        }

        public bool hasWeapon()
        {
            return true;
        }
    }
}
