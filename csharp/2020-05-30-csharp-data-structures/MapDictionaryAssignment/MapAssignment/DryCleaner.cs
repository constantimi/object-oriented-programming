using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapAssignment
{
    public class DryCleaner
    {
        private Dictionary<Ticket, Item[]> _map;
        private List<Item> _items;
        private Ticket _ticket;

        public Dictionary<Ticket, Item[]> Map { get => _map; set => _map = value; }
        public List<Item> Items { get => _items; set => _items = value; }
        public Ticket Ticket { get => _ticket; set => _ticket = value; }

        public DryCleaner()
        {
            this.Map = new Dictionary<Ticket, Item[]>();
            this.Items = new List<Item>();
        }

        public void AddItem(string name, ServiceType type)
        {
            Item item = new Item(name, type);
            this.Items.Add(item);
            this.Ticket.Items = this.Items.ToArray();
        }

        public void CreateTicket(string ticketNumber, string clientName)
        {
            this.Ticket = new Ticket(ticketNumber, clientName, Items.ToArray());
        }

        public Ticket GeTicket()
        {
            return this.Ticket;
        }
    }
}
