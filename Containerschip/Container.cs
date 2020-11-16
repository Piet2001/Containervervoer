using System;
using System.Collections.Generic;
using System.Text;

namespace Containerschip
{
    public class Container
    {
        public ContainerType Type { get; private set; }
        public int Weight { get; private set; }
        private int minWeight = 4;
        private int maxWeight = 30;

        public Container(ContainerType type, int weight)
        {
            Type = type;
            if (weight < minWeight)
            {
                Weight = minWeight;
            }
            else if(weight>maxWeight)
            {
                Weight = maxWeight;
            }
            else
            {
                Weight = weight;
            }
        }

        public override string ToString()
        {
            string result = Type.ToString() + " (" + Weight.ToString() + ")";
            return result;
        }
    }
}
