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
            List<Container> Valuable = unOrderdContainers.Where(container => container.Type == ContainerType.Valuable)
                .ToList();
            List<Container> Valuable_Coolable = unOrderdContainers.Where(container => container.Type == ContainerType.Valuable_Coolable)
                .ToList();
            List<Container> Coolable = unOrderdContainers.Where(container => container.Type == ContainerType.Coolable)
                .ToList(); ;
            List<Container> Normal = unOrderdContainers.Where(container => container.Type == ContainerType.Normal)
                .ToList();

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
