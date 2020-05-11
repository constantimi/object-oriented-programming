using System;
using ITCompanyApp.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CompanyTest
    {        
        [TestMethod]
        public void NewCompanyTest()
        {
            Company c = new Company();

            Assert.AreEqual(0, c.GetDevelopers().Length);
            Assert.AreEqual(0, c.GetCompanyBases().Length); 
        }
        // Tests related to developers
        [TestMethod]
        public void AddDeveloperTest()
        {
            Company c = new Company();

            Developer d1 = c.AddDeveloper(1, "John Doe");
            Developer d2 = c.AddDeveloper(2, "Donald Duck");

            CollectionAssert.AreEquivalent(new Developer[] { d1, d2 }, c.GetDevelopers());

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddDeveloperWithExistingIdTest()
        {
            Company c = new Company();
            
            Developer d1 = c.AddDeveloper(1, "John Doe");
            Developer d2 = c.AddDeveloper(1, "Donald Duck");
        }

        [TestMethod]
        public void GetDeveloperTest()
        {
            Company c = new Company();

            Developer d1 = c.AddDeveloper(1, "John Doe");
            Developer d2 = c.AddDeveloper(2, "Donald Duck");

            Developer foundDeveloper = c.GetDeveloper(2);

            Assert.AreEqual(d2, foundDeveloper);

        }
        [TestMethod]
        public void GetNonExitsingDeveloperTest()
        {
            Company c = new Company();

            Developer foundDeveloper = c.GetDeveloper(100);

            Assert.AreEqual(null, foundDeveloper);
        }

        [TestMethod]
        public void GeDevelopersTest()
        {
            Company c = new Company();

            Developer d1 = c.AddDeveloper(1, "John Doe");
            Developer d2 = c.AddDeveloper(2, "Donald Duck");

            Developer[] foundDevelopers = c.GetDevelopers();

            CollectionAssert.AreEquivalent(new Developer[] { d1, d2 }, foundDevelopers);
        }

        // CompanyBases tests
        [TestMethod]
        public void AddCompanyBaseTest()
        {
            Company c = new Company();

            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);     

            CollectionAssert.AreEquivalent(new CompanyBase[] { t1 }, c.GetCompanyBases());
        }

        // Priority tests
        [TestMethod]
        public void AddCompanyBasesByPriorityTest()
        {
            Company c = new Company();

            // Priority NORMAL
            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);
           
            // Priority HIGH
            CompanyBase t2 = c.AddMeeting(2, "Dummy Meeting 1",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(2), Priority.HIGH);

            CompanyBase t3 = c.AddMeeting(3, "Dummy Meeting 2",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(2), Priority.HIGH);

            CollectionAssert.AreEquivalent(new CompanyBase[] { t2, t3 }, c.GetCompanyBasesByPriority(Priority.HIGH));
        }

        // Sorting tests
        [TestMethod]
        public void AddCompanyBasesSortedTest()
        {
            Company c = new Company();

            // Priority NORMAL
            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);

            // Priority HIGH
            CompanyBase t2 = c.AddMeeting(2, "Dummy Meeting 1",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(1), Priority.HIGH);

            CompanyBase t3 = c.AddMeeting(3, "A",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(2), Priority.HIGH);

            CompanyBase t4 = c.AddMeeting(4, "Dummy Meeting 3",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(4), Priority.HIGH);

            CompanyBase t5 = c.AddMeeting(5, "Z",
               "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
               DateTime.Now.AddDays(2), Priority.HIGH);

            // Take all tasks by Priority
            CollectionAssert.AreEquivalent(new CompanyBase[] { t2, t3, t4, t5 }, c.GetCompanyBasesSorted(Priority.HIGH));

            // Are they sorted
            int[] expectedIDs = {2, 3, 5, 4};
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(expectedIDs[i], c.GetCompanyBasesSorted(Priority.HIGH)[i].Id);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddTimedItemWithExistingIdTest()
        {
            Company c = new Company();
            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);
            CompanyBase t2 = c.AddToDo(1, "Dummy To Do 2",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);
        }

        [TestMethod]
        public void GetCompanyBasesTest()
        {
            Company c = new Company();

            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);
            CompanyBase t2 = c.AddToDo(2, "Dummy To Do 2",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);

            CompanyBase foundCompanyBase = c.GetCompanyBase(2);

            Assert.AreEqual(t2, foundCompanyBase);

        }
        [TestMethod]
        public void GetNonExitsingTimedTaskTest()
        {
            Company c = new Company();

            CompanyBase foundCompanyBase = c.GetCompanyBase(100);

            Assert.AreEqual(null, foundCompanyBase);
        }

        [TestMethod]
        public void GeTimedTasksTest()
        {
            Company c = new Company();

            CompanyBase t1 = c.AddToDo(1, "Dummy To Do 1",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);
            CompanyBase t2 = c.AddToDo(2, "Dummy To Do 2",
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi.",
                DateTime.Now.AddDays(2), Priority.NORMAL);

            CollectionAssert.AreEquivalent(new CompanyBase[] { t1, t2 }, c.GetCompanyBases());
        }
    }
}
