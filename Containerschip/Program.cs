using System;
using System.Collections.Generic;

namespace Containerschip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Container> containers = new List<Container>();
            containers.Add( new Container(ContainerType.Normal, 20));
            containers.Add(new Container(ContainerType.Normal, 21));
            containers.Add(new Container(ContainerType.Valuable_Coolable, 25));
            containers.Add(new Container(ContainerType.Valuable,23));
            containers.Add(new Container(ContainerType.Coolable, 24));

            Ship ship = new Ship(3, 3, 1080);

            if (ship.CheckMinWeight(containers) && ship.CheckMaxWeight(containers))
            {
                Shiploader loader = new Shiploader(ship, containers);
            }

            Console.WriteLine();
            Console.WriteLine("Out");
            Console.WriteLine();
            Console.WriteLine(ship);

            Console.ReadLine();
        }
    }
}
