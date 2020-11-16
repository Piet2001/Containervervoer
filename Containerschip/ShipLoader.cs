using System;
using System.Collections.Generic;
using System.Linq;

namespace Containerschip
{
    public class Shiploader
    {
        private Ship Ship;
        private readonly List<Container> unOrderdContainers;
        private List<Container> orderdContainers = new List<Container>();

        public Shiploader(Ship ship, List<Container> containers)
        {
            this.Ship = ship;
            unOrderdContainers = containers;
            OrderContainers();
        }

        private void OrderContainers()
        {
            List<Container> Valuable = new List<Container>();
            List<Container> Valuable_Coolable = new List<Container>();
            List<Container> Coolable = new List<Container>();
            List<Container> Normal = new List<Container>();

            foreach (var container in unOrderdContainers)
            {
                if (container.Type == ContainerType.Valuable)
                {
                    Valuable.Add(container);
                }
                if (container.Type == ContainerType.Coolable)
                {
                    Coolable.Add(container);
                }
                if (container.Type == ContainerType.Valuable_Coolable)
                {
                    Valuable_Coolable.Add(container);
                }
                if (container.Type == ContainerType.Normal)
                {
                    Normal.Add(container);
                }
                Console.WriteLine(container + " Gesorteerd");
            }
            Valuable.OrderByDescending(t => t.Weight);
            Coolable.OrderByDescending(t => t.Weight);
            Valuable_Coolable.OrderBy(t => t.Weight);
            Normal.OrderByDescending(t => t.Weight);

            AddContainersToShip(Valuable_Coolable);
            AddContainersToShip(Valuable);
            AddContainersToShip(Coolable);
            AddContainersToShip(Normal);
        }

        private void AddContainersToShip(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (Ship.AddContainer(container))
                {
                    Console.WriteLine(container + " Geplaatst op schip");
                }
                else
                {
                    Console.WriteLine("Container "+ container +"kon niet worden geplaatst.");
                }
            }
        }
    }
}
