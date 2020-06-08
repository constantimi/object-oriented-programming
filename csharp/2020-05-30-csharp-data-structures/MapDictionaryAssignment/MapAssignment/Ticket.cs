using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAssignment
{
    public class Ticket
    {
        private string _ticketNumber;
        private string _clientName;
        private Item[] _items;

        public Ticket(string ticketNumber, string clientName, Item[] items)
        {
            this.TicketNumber = ticketNumber;
            this.ClientName = clientName;
            this.Items = items;
        }

        public string TicketNumber { get => _ticketNumber;
            set => _ticketNumber = value; }
        public string ClientName { get => _clientName; set => _clientName = value; }
        public Item[] Items { private get => _items; set => _items = value; }

        public string[] GetItems()
        {
            List<string> stringItems = new List<string>();

            foreach (var item in this.Items)
            {
                stringItems.Add(item.ToString());
            }

            return stringItems.ToArray();
        }
    }
}
