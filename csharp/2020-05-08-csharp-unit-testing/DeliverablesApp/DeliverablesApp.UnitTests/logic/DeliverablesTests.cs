using System;
using logic.DeliverablesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logic.DeliverablesApp.UnitTests
{
    [TestClass]
    public class DeliverablesTests
    {
        [TestMethod]
        public void TestCreateADeliverable()
        {
            // Arrange
            Deliverable d = new Deliverable(22, 350,  new Person("John", "Mainstreet", 2, "5688GE", "Eindhoven"));

            // Assert
            Assert.AreEqual(d.ID, 22);
            Assert.AreEqual(d.Iperson.Name, "John");
            Assert.AreEqual(d.Iperson.Street, "Mainstreet");
            Assert.AreEqual(d.Iperson.Housenumber, 2);
            Assert.AreEqual(d.Iperson.Postalcode, "5688GE");
            Assert.AreEqual(d.Iperson.City, "Eindhoven");
        }

        [TestMethod]
        public void TestToStringDeliverable()
        {
            // Arrange
            Deliverable d = new Deliverable(22, 350, new Person("John", "Mainstreet", 2, "5688GE", "Eindhoven"));

            
            // Action
            string result = d.ToString();

            // Assert
            Assert.AreEqual(result, "Id: 22, weight: 350, should be delivered at: John - Mainstreet  2 - 5688GE  Eindhoven");
         
        }

    }
}
