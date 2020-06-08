using Microsoft.VisualStudio.TestTools.UnitTesting;
using MapAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAssignment.Tests
{
    [TestClass()]
    public class ItemTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Item item = new Item("name", ServiceType.Laundry);

            Assert.AreEqual(item.ToString(), $"name for {ServiceType.Laundry}");
        }

    }
}