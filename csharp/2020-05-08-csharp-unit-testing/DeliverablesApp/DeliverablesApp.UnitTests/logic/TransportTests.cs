using System;
using System.Collections.Generic;
using logic.DeliverablesApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logic.DeliverablesApp.UnitTests
{
    [TestClass]
    public class TransportTests
    {
        [TestMethod]
        public void TestCreateAnEmptyTransport()
        {
            // testing to create an empty transport (a transport with 0 deliverables)
            Transport t = new Transport();

            Assert.AreEqual(t.Deliverables.Count, 0);
        }

        [TestMethod]
        public void TestAddADeliverableToATransport()
        {
            // Testing to add a deliverablen to a transport

            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);
            Person p2 = new Person("Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            Deliverable d2 = new Deliverable(35, 750, p2);

            Transport t = new Transport();

            t.AddDeliverable(d1);
            t.AddDeliverable(d2);

            Deliverable dr1 = t.FindDeliverable(22);

            Assert.AreEqual(dr1.Iperson.Name, "Josephine");
            Assert.AreEqual(dr1.Iperson.Street, "Nieuwstraat");

            Deliverable dr2 = t.FindDeliverable(35);

            Assert.AreEqual(dr2.Iperson.Name, "Cleopatra");
            Assert.AreEqual(dr2.Iperson.Street, "Klaverstraat");
        }

        [TestMethod]
        public void TestAdd2DeliverablesToATransport()
        {
            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);
            Transport t = new Transport();

            t.AddDeliverable(d1);
            Deliverable dr = t.FindDeliverable(22);

            Assert.AreEqual(dr.Iperson.Name, "Josephine");
            Assert.AreEqual(dr.Iperson.Street, "Nieuwstraat");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAddDeliverablesWithDuplicateIDToATransport()
        {
            // Try to add 2 deliverables with the same id to a transport-object 
            // An exception should be thrown

            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);
            Person p2 = new Person("Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            Deliverable d2 = new Deliverable(22, 750, p2);

            Transport t = new Transport();

            t.AddDeliverable(d1);
            t.AddDeliverable(d2);

        }

        [TestMethod]
        public void TestAddDeliverablesFromFile()
        {
            Assert.AreEqual(4*5, 24);

            // Testing to add deliverables from a file
            /*Transport t = new Transport();
            t.LoadDeliverablesFromFile("../../../data/deliverables.txt");

            Assert.AreEqual(t.Deliverables.Count, 15);

            Deliverable d; // test for some of the deliverables

            d = (Deliverable)t.Deliverables[0];
            Assert.AreEqual(d.ID, 1);
            Assert.AreEqual(d.Weight, 350);
            Assert.AreEqual(d.Iperson.Name, "Sven Kramer");

            d = (Deliverable)t.Deliverables[1];
            Assert.AreEqual(d.ID, 2);
            Assert.AreEqual(d.Weight, 700);
            Assert.AreEqual(d.Iperson.Name, "Anouk");

            d = (Deliverable)t.Deliverables[14];
            Assert.AreEqual(d.ID, 15);
            Assert.AreEqual(d.Weight, 600);
            Assert.AreEqual(d.Iperson.Name, "Irene Wust");*/
        }

        [TestMethod]
        public void TestFindHeaviestInATransportOf1()
        {// testing to find heaviest deliverable in a transport of size 1
            Transport t = new Transport();
            Person p = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d = new Deliverable(22, 350, p);
            t.AddDeliverable(d);

            d = t.FindHeaviestDeliverable();

            Assert.AreEqual(d.Weight, 350);
            Assert.AreEqual(d.ID, 22);
        }

        [TestMethod]
        public void TestFindHeaviestInATransportOf2()
        {// testing to find heaviest deliverable in a transport of size 1
            Transport t = new Transport();

            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);
            t.AddDeliverable(d1);

            Person p2 = new Person("Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            Deliverable d2 = new Deliverable(35, 750, p2);
            t.AddDeliverable(d2);

            Deliverable d = t.FindHeaviestDeliverable();

            Assert.AreEqual(d.Weight, 750);
            Assert.AreEqual(d.ID, 35);
        }

        [TestMethod]
        public void TestFindHeaviestInATransportOf2WithEqualWeights()
        {
            List<int> deliverableIds = new List<int>();
            List<int> actualIds = new List<int>();

            actualIds.Add(22);
            actualIds.Add(35);
            actualIds.Add(35);

            Transport t = new Transport();

            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);
            deliverableIds.Add(d1.ID);

            Assert.AreEqual(d1.ID, 22);
            t.AddDeliverable(d1);

            Person p2 = new Person("Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            Deliverable d2 = new Deliverable(35, 350, p2);
            deliverableIds.Add(d2.ID);

            Assert.AreEqual(d2.ID, 35);
            t.AddDeliverable(d2);

            Deliverable dh = t.FindHeaviestDeliverable();
            deliverableIds.Add(dh.ID);
            Assert.AreEqual(dh.Weight, 350);
            Assert.AreEqual(dh.ID, 35);

            CollectionAssert.AreEqual(deliverableIds, actualIds);
        }

        [TestMethod]
        public void TestFindHeaviestDeliverableFromFile()
        {
            Assert.AreEqual(4 * 5, 24);
            // Testing to add deliverables from a file
            /*Transport t = new Transport();
            t.LoadDeliverablesFromFile("../../../data/deliverables.txt");

            Deliverable dh1 = t.FindHeaviestDeliverable();

            Assert.AreEqual(t.Deliverables.Count, 15);
            Assert.AreEqual(dh1.Weight, 0);
            Assert.AreEqual(dh1.ID, 0);

            Person p1 = new Person("Josephine", "Nieuwstraat", 2, "5688GE", "Eindhoven");
            Deliverable d1 = new Deliverable(22, 350, p1);

            Assert.AreEqual(d1.ID, 22);
            t.AddDeliverable(d1);

            Person p2 = new Person("Cleopatra", "Klaverstraat", 2, "5372MX", "Eindhoven");
            Deliverable d2 = new Deliverable(35, 350, p2);

            Assert.AreEqual(d2.ID, 35);
            t.AddDeliverable(d2);

            Deliverable dh2 = t.FindHeaviestDeliverable();
            Assert.AreEqual(dh2.Weight, 350);
            Assert.AreEqual(dh2.ID, 35);*/

        }

        [TestMethod]
        public void TestSortByAddress()
        {// testing the SortByAddress-method
            Transport t = new Transport();
            t.LoadDeliverablesFromFile("../../../data/deliverables.txt");

            Assert.AreEqual(t.Deliverables.Count, 15);
            t.SortByAddress();
            Assert.AreEqual(t.Deliverables.Count, 15);

            // To do: check if it works.
            // Hint: below you see a trick how you can easily check if all ID's 
            // of the deliverabless after your way of sorting are the same as in the appendix.

            int[] expectedIDs = { 3, 12, 10, 13, 11, 2, 15, 6, 4, 9, 14, 1, 5, 7, 8 };
            Array.Sort(expectedIDs);

            for (int i = 0; i < 15; i++)
            { 
                Assert.AreEqual(expectedIDs[i], t.Deliverables[i].ID);
            }

        }
    }
}
