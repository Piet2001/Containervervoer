using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Containerschip
{
    public class Ship
    {
        private int length;
        private int width;
        private int maxWeight;
        private int minWeight;

        public Ship(int length, int width, int maxWeight)
        {
            this.length = length;
            this.width = width;
            this.maxWeight = maxWeight;
            minWeight = maxWeight / 2;
        }

        public bool CheckMaxWeight(List<Container> containers)
        {
            if (containers.Sum(t => t.Weight) > maxWeight)
            {
                return false;
            }

            return true;
        }

        public bool CheckMinWeight(List<Container> containers)
        {
            if (containers.Sum(t => t.Weight) > maxWeight)
            {
                return false;
            }

            return true;
        }
    }
}
