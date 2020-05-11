using System;
using ITCompanyApp.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ToDoTest
    {
        #region Initialize some test data
        // Note that it is actually beter to have these as constants, but we did not cover this yet.
        private string testTitle;
        private string testDecription;
        private DateTime testDueTimestamp;
        // Note that is is actually better initialize test data via [TestInitialize] public void TestInitialize(),  but we did not cover this yet.
        public ToDoTest()
        {
            this.testTitle = "Dummy to do";
            this.testDecription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.";
            this.testDueTimestamp = DateTime.Now.AddDays(2);
        }
        #endregion

        [TestMethod]
        public void NewToDoTest()
        {
            ToDo t = new ToDo(1, this.testTitle, this.testDecription, this.testDueTimestamp, Priority.NORMAL);

            Assert.AreEqual(1, t.Id);
            Assert.AreEqual(this.testTitle, t.Title);
            Assert.AreEqual(this.testDecription, t.Description);
            Assert.AreEqual(this.testDueTimestamp, t.DueTimestamp);
            Assert.AreEqual(Priority.NORMAL, t.Priority);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewToDoInvalidTitleTest()
        {
            ToDo t = new ToDo(1, "", this.testDecription, this.testDueTimestamp, Priority.NORMAL);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NewToDoInvalidDueTimestampTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, DateTime.Now.AddSeconds(-1), Priority.NORMAL);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AssignInvalidTitleTest()
        {
            ToDo t = new ToDo(1, this.testTitle, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            t.Title = " ";
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AssignInvalidDueTimestampTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            t.DueTimestamp = DateTime.Now.AddSeconds(-1);
        }

        [TestMethod]
        public void AssignDevelopersTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            Developer d1 = new Developer(1, "John Doe");
            Developer d2 = new Developer(11, "Jane Doe");
            Developer d3 = new Developer(111, "Donald Duck");

            t.AssignDeveloper(d1);
            t.AssignDeveloper(d2);
            t.AssignDeveloper(d3);

            CollectionAssert.AreEquivalent(new Developer[] { d1, d2, d3 }, t.GetAssignedDevelopers());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AssignDuplicateDevelopersTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            Developer d1 = new Developer(1, "John Doe");

            t.AssignDeveloper(d1);
            t.AssignDeveloper(d1);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AssignFourDevelopersTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            Developer d1 = new Developer(1, "John Doe");
            Developer d2 = new Developer(11, "Jane Doe");
            Developer d3 = new Developer(111, "Donald Duck");
            Developer d4 = new Developer(1111, "Bruce Lee");

            t.AssignDeveloper(d1);
            t.AssignDeveloper(d2);
            t.AssignDeveloper(d3);
            t.AssignDeveloper(d4);
        }

        [TestMethod]
        public void RemoveDeveloperTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            Developer d1 = new Developer(1, "John Doe");
            Developer d2 = new Developer(11, "Jane Doe");

            t.AssignDeveloper(d1);
            t.AssignDeveloper(d2);
            t.RemoveDeveloper(d1);

            CollectionAssert.AreEquivalent(new Developer[] { d2 }, t.GetAssignedDevelopers());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveUnknownDeveloperTest()
        {
            ToDo t = new ToDo(1, this.testDecription, this.testDecription, this.testDueTimestamp, Priority.NORMAL);
            Developer d1 = new Developer(1, "John Doe");
            Developer d2 = new Developer(11, "Jane Doe");

            t.AssignDeveloper(d1);
            t.RemoveDeveloper(d2);
        }
    }
}
