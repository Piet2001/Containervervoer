using System.Collections.Generic;
using Containerschip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Containership.Tests
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void Weight120Possible()
        {
            Ship ship = new Ship(1,1,120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable,30));
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));

            bool possible = ship.CheckMaxWeight(containers);

            Assert.IsTrue(possible);
        }
        [TestMethod]
        public void Weight121impossible()
        {
            Ship ship = new Ship(1, 1, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Normal, 21));
            containers.Add(new Container(ContainerType.Normal, 10));

            bool possible = ship.CheckMaxWeight(containers);

            Assert.IsFalse(possible);
        }
        [TestMethod]
        public void Weight60Possible()
        {
            Ship ship = new Ship(1, 1, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 30));

            bool possible = ship.CheckMinWeight(containers);

            Assert.IsTrue(possible);
        }

        [TestMethod]
        public void Weight59Impossible()
        {
            Ship ship = new Ship(1, 1, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 29));

            bool possible = ship.CheckMinWeight(containers);

            Assert.IsFalse(possible);
        }
    }
}
