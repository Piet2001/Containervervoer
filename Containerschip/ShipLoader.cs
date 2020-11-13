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
                Console.WriteLine(container.Type.ToString() + " Gesorteerd");
            }
            Valuable.OrderByDescending(t => t.Weight);
            Coolable.OrderByDescending(t => t.Weight);
            Valuable_Coolable.OrderBy(t => t.Weight);
            Normal.OrderByDescending(t => t.Weight);

            addContainersToShip(Coolable);
            addContainersToShip(Valuable_Coolable);
            addContainersToShip(Valuable);
            addContainersToShip(Normal);
        }

        private void addContainersToShip(List<Container> containers)
        {
            foreach (var container in containers)
            {
                if (Ship.AddContainer(container))
                {
                    Console.WriteLine(container.Type.ToString());
                }
                else
                {
                    Console.WriteLine("Container kon niet worden geplaatst.");
                }
            }
        }
    }
}
