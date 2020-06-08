using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAssignment
{
    public class TicketQueue : IQueueable
    {
        private Queue<Ticket> queue;

        public TicketQueue()
        {
            this.Queue = new Queue<Ticket>();
        }

        public Queue<Ticket> Queue { get => queue; set => queue = value; }

        public void AddTicket(Ticket ticket)
        {
            this.Queue.Enqueue(ticket);
        }
    }
}
