using System;
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
        [TestMethod]
        public void TwoValubleImpossible()
        {
            Ship ship = new Ship(1, 1, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 29));
            ship.AddContainer(containers[0]);
            bool possible = ship.AddContainer(containers[1]);

            Assert.IsFalse(possible);
        }

        [TestMethod]
        public void TwoValublePossibleWith2Columns()
        {
            Ship ship = new Ship(1, 2, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 29));
            ship.AddContainer(containers[0]);
            bool possible = ship.AddContainer(containers[1]);

            Assert.IsTrue(possible);
        }

        [TestMethod]
        public void ShipWeightCorrect()
        {
            Ship ship = new Ship(1, 2, 120);
            List<Container> containers = new List<Container>();
            containers.Add(new Container(ContainerType.Valuable, 30));
            containers.Add(new Container(ContainerType.Valuable, 29));
            ship.AddContainer(containers[0]);
            ship.AddContainer(containers[1]);

            Assert.AreEqual(59,ship.getTotalWeight());
        }
    }
}
