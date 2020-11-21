using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Containerschip;

namespace Containership.Tests
{
    [TestClass]
    public class ColumnTests
    {
        [TestMethod]
        public void VaCoAndNormalPossible()
        {
            Column column = new Column(1);

            column.TryAdd(new Container(ContainerType.Valuable_Coolable, 21));
            bool newvalue = column.TryAdd(new Container(ContainerType.Normal, 21));

            Assert.IsTrue(newvalue);
        }

        [TestMethod]
        public void ColumnWeight()
        {
            Column column = new Column(1);

            column.TryAdd(new Container(ContainerType.Valuable_Coolable, 21));
            column.TryAdd(new Container(ContainerType.Normal, 21));

            Assert.AreEqual(42,column.TotalWeight);
        }

        [TestMethod]
        public void TwoVaCoImPossible()
        {
            Column column = new Column(2);

            column.TryAdd(new Container(ContainerType.Valuable_Coolable, 21));
            bool newvalue = column.TryAdd(new Container(ContainerType.Valuable_Coolable, 21));

            Assert.IsFalse(newvalue);
        }

        [TestMethod]
        public void VaCoAndVaPossible()
        {
            Column column = new Column(2);

            column.TryAdd(new Container(ContainerType.Valuable_Coolable, 21));
            bool newvalue = column.TryAdd(new Container(ContainerType.Valuable, 21));

            Assert.IsTrue(newvalue);
        }
    }
}
