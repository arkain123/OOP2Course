using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Client
    {
        public void ClientOut()
        {
            MilitaryFactory milfact = new MilitaryFactory();
            CivilianFactory civfact = new CivilianFactory();

            Plane milplane = milfact.CreatePlane();
            Plane civplane = civfact.CreatePlane();

            Car milcar = milfact.CreateCar();
            Car civcar = civfact.CreateCar();

            Ship milship = milfact.CreateShip();
            Ship civship = civfact.CreateShip();

            Console.WriteLine("\t\tPlanes\n");
            Console.WriteLine("\tMilitary Planes\n");
            Console.WriteLine("Has wings: " + milplane.hasWings());
            Console.WriteLine("Has weapon: " + milplane.hasWeapon());
            Console.WriteLine();
            Console.WriteLine("\tCivilian Planes\n");
            Console.WriteLine("Has wings: " + civplane.hasWings());
            Console.WriteLine("Has weapon: " + civplane.hasWeapon());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tCar\n");
            Console.WriteLine("\tMilitary Cars\n");
            Console.WriteLine("Has wheels: " + milcar.hasWheels());
            Console.WriteLine("Has weapon: " + milcar.hasWeapon());
            Console.WriteLine();
            Console.WriteLine("\tCivilian Cars\n");
            Console.WriteLine("Has wheels: " + civcar.hasWheels());
            Console.WriteLine("Has weapon: " + civcar.hasWeapon());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tShip\n");
            Console.WriteLine("\tMilitary Ships\n");
            Console.WriteLine("Has anchor: " + milship.hasAnchor());
            Console.WriteLine("Has weapon: " + milship.hasWeapon());
            Console.WriteLine();
            Console.WriteLine("\tCivilian Ships\n");
            Console.WriteLine("Has anchor: " + civship.hasAnchor());
            Console.WriteLine("Has weapon: " + civship.hasWeapon());
        }
    }
}
