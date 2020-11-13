using System;
using System.Collections.Generic;
using System.Linq;

namespace Containerschip
{
    public class Ship
    {
        private List<Column> columns;
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

            columns = new List<Column>();

            for (int i = 0; i < width; i++)
            {
                bool first = (i == 0);
                bool last = (i == width - 1);

                columns.Add(new Column(length));
            }
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

        public bool AddContainer(Container container)
        {
            foreach (var column in columns)
            {
                if (column.TryAdd(container)) return true;
            }
            return false;
        }

        private int LeftWeight()
        {
            int weight = 0;
            int leftColumns;
            if (columns.Count % 2 == 0)
            {
                leftColumns = columns.Count / 2;
            }
            else
            {
                leftColumns = (int) Math.Floor(columns.Count / 2.0);
            }

            for (int i = 0; i < leftColumns; i++)
            {
                weight += columns[i].totalWeight;
            }

            return weight;
        }

        private int RightWeight()
        {
            int weight = 0;
            int min;
            if (columns.Count % 2 ==0)
            {
                min = (int) (columns.Count / 2);
            }
            else
            {
                min = (int) Math.Ceiling(columns.Count / 2.0);
            }

            for (int i = min; i < columns.Count; i++)
            {
                weight += columns[i].totalWeight;
            }

            return weight;
        }

        public override string ToString()
        {
            string result = null;
            int amountColumns = 1;
            foreach (var column in columns)
            {
                result += "Column " + amountColumns + ": \n";
                result += column;
                amountColumns++;
            }

            return result;
        }
    }
}
