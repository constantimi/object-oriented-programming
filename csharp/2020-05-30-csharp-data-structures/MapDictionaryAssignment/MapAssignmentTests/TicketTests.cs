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
    public class TicketTests
    {
        [TestMethod()]
        public void GetItemsTest()
        {
            List<Item> items = new List<Item>();
            List<string> stringItems = new List<string>();

            Item item1 = new Item("name1", ServiceType.Laundry);
            Item item2 = new Item("name2", ServiceType.DryCleaning);
            Item item3 = new Item("name3", ServiceType.ShoeRepair);

            items.Add(item1);
            items.Add(item2);
            items.Add(item3);


            Ticket ticket = new Ticket("0004", "John", items.ToArray());


            foreach (var item in items)
            {
                stringItems.Add(item.ToString());
            } 

            // Check the collections
            CollectionAssert.AreEquivalent( ticket.GetItems(), stringItems.ToArray());

            // Check the constructor
            Assert.AreSame(ticket.ClientName, "John");
            Assert.AreSame(ticket.TicketNumber, "0004");
        }
    }
}