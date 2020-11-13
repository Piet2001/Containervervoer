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
            this.Type = type;
            if (weight < minWeight)
            {
                this.Weight = minWeight;
            }
            else if(weight>maxWeight)
            {
                this.Weight = maxWeight;
            }
            else
            {
                this.Weight = weight;
            }
        }

    }
}
