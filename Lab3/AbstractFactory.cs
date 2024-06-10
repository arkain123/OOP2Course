using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface AbstractFactory
    {
        Car CreateCar();
        Plane CreatePlane();
        Ship CreateShip();
    }
}
