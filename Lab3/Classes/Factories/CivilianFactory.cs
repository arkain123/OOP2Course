using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class CivilianFactory: AbstractFactory
    {
        public Car CreateCar()
        {
            return new CivilianCar();
        }

        public Plane CreatePlane()
        {
            return new CivilianPlane();
        }

        public Ship CreateShip()
        {
            return new CivilianShip();
        }
    }
}
