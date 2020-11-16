using System.Collections.Generic;
using System.Linq;

namespace Containerschip
{
    public class Stack
    {
        private const int maxStackWeight = 120;
        private List<Container> containersInStack { get; }
        private bool first;
        private bool last;

        public Stack(bool first, bool last)
        {
            containersInStack = new List<Container>();
            this.first = first;
            this.last = last;
        }

        public int totalWeight => containersInStack.Sum(t => t.Weight);
        // public bool containersInStack.Any(vleeseter => dier.Grootte <= vleeseter.Grootte

        private bool IsStackSafe()
        {
            return totalWeight <= maxStackWeight;
        }

        private bool wightAccept(Container container)
        {
            int newWight = totalWeight + container.Weight;
            if (newWight >= maxStackWeight) return false;
            containersInStack.Add(container);
            return true;

        }

        public bool ValuablePlaceAvailable()
        {
            return !containersInStack.Any(t => t.Type == ContainerType.Valuable || t.Type == ContainerType.Valuable_Coolable);
        }

        public bool TryToAdd(Container container)
        {
            

            if (container.Type == ContainerType.Coolable && first)
            {
                if (wightAccept(container))
                {
                    return true;
                }

                return false;
            }

            if (container.Type == ContainerType.Valuable_Coolable && first)
            {
                if (wightAccept(container)) return true;
 
                return false;
            }

            if (container.Type == ContainerType.Valuable && (first || last))
            {
                if (wightAccept(container)) return true;

                return false;
            }

            if (container.Type == ContainerType.Normal)
            {
                if (wightAccept(container)) return true;

                return false;
            }
            return false;
        }

        public override string ToString()
        {
            string result = null;
            int amountContainers = 1;
            foreach (var container in containersInStack)
            {
                result += "container " + amountContainers + ": ";
                result += container + "\n";
                amountContainers++;
            }
            result += "== Total stack weight: " + totalWeight + " ton \n";
            return result;
        }
    }
}
