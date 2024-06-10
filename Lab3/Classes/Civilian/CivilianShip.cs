using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class CivilianShip: Ship
    {
        public bool hasAnchor()
        {
            return true;
        }

        public bool hasWeapon()
        {
            return false;
        }
    }
}
