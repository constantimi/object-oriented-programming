using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueAssignment
{
    public partial class RequestQueueForm : Form, IRequestable
    {
        private TicketQueue ticketQueue;
        private QueueForm queueForm;
        public RequestQueueForm(QueueForm queueForm ,TicketQueue ticketQueue)
        {
            InitializeComponent();
            this.ticketQueue = ticketQueue;

            this.btnGetNextTicket.Enabled = true;
            this.btnHandleIt.Enabled = false;
        }

        public Ticket GetTicket()
        {
            return this.ticketQueue.Queue.Peek();
        }

        private void btnGetNextTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetTicket();

            this.txName.Text = ticket.Name;
            this.txEmail.Text = ticket.Email;
            this.txDescription.Text = ticket.Description;
            this.txTicketId.Text = ticket.TicketId.ToString();

            this.btnGetNextTicket.Enabled = false;
            this.btnHandleIt.Enabled = true;
        }

        private void btnHandleIt_Click(object sender, EventArgs e)
        {
            this.ticketQueue.Queue.Dequeue();

            this.btnGetNextTicket.Enabled = true;
            this.btnHandleIt.Enabled = false;

            this.queueForm = new QueueForm(this.ticketQueue);
            this.queueForm.Show();
            this.Close();
            
        }
    }
}
