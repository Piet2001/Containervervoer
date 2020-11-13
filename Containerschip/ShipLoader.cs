using System;
using System.Collections.Generic;
using System.Linq;

namespace Containerschip
{
    public class Shiploader
    {
        public Ship Ship;
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
                if (container.Type == ContainerType.Valuable || container.Type == ContainerType.Valuable_Coolable)
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
        }
    }
}
