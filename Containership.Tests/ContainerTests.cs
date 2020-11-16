using Containerschip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Containership.Tests
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void CorrectWeightDontChange()
        {
            Container container = new Container(ContainerType.Normal, 30);

            Assert.AreEqual(30, container.Weight);
        }
        [TestMethod]
        public void CorrectWeightDontChange2()
        {
            Container container = new Container(ContainerType.Normal, 4);

            Assert.AreEqual(4, container.Weight);
        }
        [TestMethod]
        public void Under4ChangeTo4()
        {
            Container container = new Container(ContainerType.Normal, 3);

            Assert.AreEqual(4, container.Weight);
        }
        [TestMethod]
        public void Above30ChangeTo30()
        {
            Container container = new Container(ContainerType.Normal, 31);

            Assert.AreEqual(30, container.Weight);
        }
    }
}
