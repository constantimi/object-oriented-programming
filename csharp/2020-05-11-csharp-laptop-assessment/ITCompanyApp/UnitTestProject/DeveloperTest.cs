using System;
using ITCompanyApp.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DeveloperTest
    {
        [TestMethod]
        public void NewDeveloperTest()
        {
            Developer d = new Developer(1, "John Doe");

            Assert.AreEqual(1, d.Id);
            Assert.AreEqual("John Doe", d.Name);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewTDveloperInvalidNameTest()
        {
            Developer d = new Developer(1, " ");
        }

        [TestMethod]
        public void ToStringTest()
        {
            Developer d1 = new Developer(1, "John Doe");
            Developer d2 = new Developer(11, "Jane Doe");
            Developer d3 = new Developer(111, "Donald Duck");
            Developer d4 = new Developer(1111, "Bruce Lee");
            Developer d5 = new Developer(11111, "Janet Johnson");

            Assert.AreEqual("0001 - John Doe", d1.ToString());
            Assert.AreEqual("0011 - Jane Doe", d2.ToString());
            Assert.AreEqual("0111 - Donald Duck", d3.ToString());
            Assert.AreEqual("1111 - Bruce Lee", d4.ToString());
            Assert.AreEqual("11111 - Janet Johnson", d5.ToString());
        }
    }
}
