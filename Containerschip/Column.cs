using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Containerschip
{
    class Column
    {
        private List<Stack> stacks { get; set; }
        private int _length;
        public int totalWeight => stacks.Sum(t => t.totalWeight);

        public Column(int length)
        {
            this._length = length;
            stacks = new List<Stack>();
            for (int i = 0; i < length; i++)
            {
                bool first = (i == 0);
                bool last = (i == (length - 1));

                stacks.Add(new Stack(first, last));
            }
        }

        public bool TryAdd(Container container)
        {
            for (int i = 0; i < _length; i++)
            {
                if (container.Type == ContainerType.Valuable || container.Type == ContainerType.Valuable_Coolable)
                {
                    if (stacks[i].ValuablePlaceAvailable())
                    {
                        if (stacks[i].TryToAdd(container)) return true;
                    }
                    continue;
                }
                if (stacks[i].TryToAdd(container)) return true;
            }
            return false;
        }

        public override string ToString()
        {
            string result = null;
            int amountStacks = 1;
            foreach (var stack in stacks)
            {
                result += "stack " + amountStacks + ": \n";
                result += stack;
                amountStacks++;
            }

            result += "=== total columnweight: " + totalWeight + " ton \n\n";
            return result;
        }
    }
}
