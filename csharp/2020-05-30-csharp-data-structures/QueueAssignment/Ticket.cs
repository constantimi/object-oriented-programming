using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAssignment
{
    public class Ticket
    {
        private string name;
        private string email;
        private string description;
        private int ticketId;

        public Ticket(string name, string email, string description, int ticket)
        {
            this.Name = name;
            this.Email = email;
            this.Description = description;
            this.TicketId = ticket;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Description { get => description; set => description = value; }
        public int TicketId { get => ticketId; set => ticketId = value; }
    }
}
