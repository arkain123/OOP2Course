using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class CivilianPlane: Plane
    {
        public bool hasWings()
        {
            return true;
        }

        public bool hasWeapon()
        {
            return false;
        }
    }
}
