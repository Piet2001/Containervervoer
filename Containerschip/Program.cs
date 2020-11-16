using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Containerschip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            List<Container> containers = new List<Container>();
            containers.Add( new Container(ContainerType.Normal, 20));
            containers.Add(new Container(ContainerType.Normal, 21));
            containers.Add(new Container(ContainerType.Valuable_Coolable, 25));
            containers.Add(new Container(ContainerType.Valuable,23));
            containers.Add(new Container(ContainerType.Coolable, 24));
            containers.Add(new Container(ContainerType.Coolable, 30));
            containers.Add(new Container(ContainerType.Coolable, 29));
            containers.Add(new Container(ContainerType.Coolable, 28));
            containers.Add(new Container(ContainerType.Valuable, 23));
            containers.Add(new Container(ContainerType.Valuable, 21));
            containers.Add(new Container(ContainerType.Valuable_Coolable, 10));
            containers.Add(new Container(ContainerType.Valuable_Coolable, 8));
            containers.Add(new Container(ContainerType.Normal, 7));
            containers.Add(new Container(ContainerType.Normal, 14));
            containers.Add(new Container(ContainerType.Normal, 18));
            containers.Add(new Container(ContainerType.Normal, 16));
            containers.Add(new Container(ContainerType.Normal, 12));
            containers.Add(new Container(ContainerType.Normal, 15));
            containers.Add(new Container(ContainerType.Normal, 18));
            containers.Add(new Container(ContainerType.Normal, 28));
            containers.Add(new Container(ContainerType.Normal, 23));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 24));
            containers.Add(new Container(ContainerType.Normal, 30));
            containers.Add(new Container(ContainerType.Normal, 21));
            containers.Add(new Container(ContainerType.Normal, 12));
            containers.Add(new Container(ContainerType.Normal, 11));
            containers.Add(new Container(ContainerType.Normal, 8));
            containers.Add(new Container(ContainerType.Normal, 29));
            containers.Add(new Container(ContainerType.Normal, 22));
            containers.Add(new Container(ContainerType.Normal, 5));
            containers.Add(new Container(ContainerType.Normal, 27));
            containers.Add(new Container(ContainerType.Normal, 30));
            containers.Add(new Container(ContainerType.Normal, 30));
            containers.Add(new Container(ContainerType.Coolable, 30));
            containers.Add(new Container(ContainerType.Coolable, 30));
            containers.Add(new Container(ContainerType.Coolable, 30));
            containers.Add(new Container(ContainerType.Coolable, 30));
            containers.Add(new Container(ContainerType.Coolable, 4));
            containers.Add(new Container(ContainerType.Coolable, 4));
            containers.Add(new Container(ContainerType.Valuable, 8));


            Ship ship = new Ship(4, 3, 1080);

            if (ship.CheckMinWeight(containers) && ship.CheckMaxWeight(containers))
            {
                Shiploader loader = new Shiploader(ship, containers);

                Console.WriteLine();
                Console.WriteLine("De geplaaste containers zijn op de volgende plekken geplaatst: ");
                Console.WriteLine();
                Console.WriteLine(ship); 
            }
            else
            {
                Console.WriteLine("Het totale gewicht van de containers voldoet niet aan de eisen van het schip!");
            }


            Console.ReadLine();
        }
    }
}
