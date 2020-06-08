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
    public partial class QueueForm : Form
    {
        private TicketQueue ticketQueue;
        private RequestQueueForm disposal;
        public QueueForm()
        {
            InitializeComponent();
            this.ticketQueue = new TicketQueue();
        }

        public QueueForm(TicketQueue ticketQueue)
        {
            InitializeComponent();
            this.ticketQueue = ticketQueue;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = (string) this.txName.Text;
            string email = (string)this.txEmail.Text;
            string desctiption = (string)this.txDescription.Text;
            int ticketId = Convert.ToInt32(this.txTicketId.Text);

            Ticket ticket = new Ticket(name, email, desctiption, ticketId);

            this.ticketQueue.AddTicket(ticket);

            this.disposal = new RequestQueueForm(this, this.ticketQueue);
            this.disposal.Show();
            this.Hide();
        }
    }
}
