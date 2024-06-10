using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class MilitaryFactory: AbstractFactory
    {
        public Car CreateCar()
        {
            return new MilitaryCar();
        }

        public Plane CreatePlane()
        {
            return new MilitaryPlane();
        }

        public Ship CreateShip()
        {
            return new MilitaryShip();
        }
    }
}
