using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapAssignment
{
    public partial class FormMap : Form
    {
        private Dictionary<string, DryCleaner> _mapTicketDryCleaners;

        public FormMap()
        {
            InitializeComponent();
            this.MapTicketDryCleaners = new Dictionary<string, DryCleaner>();
        }

        public Dictionary<string, DryCleaner> MapTicketDryCleaners { get => _mapTicketDryCleaners; set => _mapTicketDryCleaners = value; }


        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            string clientName, ticketNumber;
            Regex clientNameRegex, tickeNumbeRegex;

            clientNameRegex = new Regex("^[a-zA-Z]+$");
            tickeNumbeRegex = new Regex("^[0-9]+$");

            clientName = String.IsNullOrEmpty(this.txClientName.Text) ? "Default Name" : this.txClientName.Text;
            ticketNumber = String.IsNullOrEmpty(this.txTicketNumber.Text) ? "0001" : String.Format("{0:0000}", this.txTicketNumber.Text);

            if (!clientNameRegex.IsMatch(Regex.Replace(clientName, @"\s+", "")))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use appropirate client name! Only letters.");
                return;
            } 
            
            if (!tickeNumbeRegex.IsMatch(ticketNumber))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use appropriate ticket number. Only numbers.");
                return;
            }

            if (this.MapTicketDryCleaners.ContainsKey(ticketNumber) && !String.IsNullOrEmpty(this.txClientName.Text))
            {
                this.MapTicketDryCleaners[ticketNumber].Ticket.ClientName = this.txClientName.Text;

                // Success message
                MessageBox.Show("Successfully updated client name!");
                return;
            }
            else if (this.MapTicketDryCleaners.ContainsKey(ticketNumber))
            {
                // Error message
                MessageBox.Show("Use another ticket number");
                return;
            }
            else
            {
                DryCleaner dryCleaner = new DryCleaner();
                dryCleaner.CreateTicket(ticketNumber, clientName);
                this.MapTicketDryCleaners.Add(ticketNumber, dryCleaner);

                // Success message
                MessageBox.Show("You have created a ticket!");
                this.txTicketNumber.Text = ticketNumber;
            }
            
            // Iterface updates
            this.lbItems.Items.Clear();
            DomainUpDownAddInformation();

        }


        private void DomainUpDownAddInformation()
        {
            // Add to the search field
            this.domainUpDown.Items.Clear();
            this.domainUpDown.Items.AddRange(this.MapTicketDryCleaners.Keys);
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName, ticketNumber;
            Regex itemNameRegex, tickeNumbeRegex;


            if (String.IsNullOrEmpty(this.txTicketNumber.Text) || String.IsNullOrEmpty(this.txItemName.Text))
            {
                // Empty fields
                MessageBox.Show("Empty fields!");
                return;
            }

            itemName  = this.txItemName.Text;
            ticketNumber = String.Format("{0:0000}", this.txTicketNumber.Text);

            itemNameRegex = new Regex("^[a-zA-Z]+$");
            tickeNumbeRegex = new Regex("^[0-9]+$");


            if (!itemNameRegex.IsMatch(Regex.Replace(itemName, @"\s+", "")))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use appropirate item name! Only letters.");
                return;
            }

            if (!tickeNumbeRegex.IsMatch(ticketNumber))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use existing ticket number or create one!");
                return;
            }

            if (!this.MapTicketDryCleaners.ContainsKey(ticketNumber))
            {
                // Error message
                MessageBox.Show("Use existing ticket number");
                return;
            }
            else
            {
                ServiceType service = ServiceType.Laundry;
                if (this.radioDryCleaning.Checked) { service = ServiceType.DryCleaning; }
                if (this.radioShoeRepair.Checked) { service = ServiceType.ShoeRepair; }

                Item item = new Item(itemName, service);

                if (this.MapTicketDryCleaners[ticketNumber].Items.Where(i => ( i.Name == itemName) && (i.Type == service)).Count() != 0)
                {
                    // Contains this item
                    MessageBox.Show("Contains this item!");
                    return;
                }

                this.MapTicketDryCleaners[ticketNumber].Items.Add(item);
                
                this.lbItems.Items.Clear();

                UpdateListInformation(ticketNumber);

                // Success message
                MessageBox.Show($"You have added the {itemName} to {service}!");
            }

        }

        private void UpdateListInformation(string ticketNumber)
        {
            foreach (var i in this.MapTicketDryCleaners[ticketNumber].Items)
            {
                this.lbItems.Items.Add(i.ToString());
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ticketNumber;
            Regex tickeNumbeRegex;

            this.lbFoundItems.Items.Clear();

            try
            {
               tickeNumbeRegex = new Regex("^[0-9]+$");
               ticketNumber = String.Format("{0:0000}", this.domainUpDown.Text);
            }
            catch(Exception)
            {
                // Empty fields
                MessageBox.Show("Empty fields!");
                return;
            }

           

            if (!tickeNumbeRegex.IsMatch(ticketNumber))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use existing ticket number.");
                return;
            }

            if (!this.MapTicketDryCleaners.ContainsKey(ticketNumber))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use existing ticket number.");
                return;
            }

            DryCleaner dryCleaner = this.MapTicketDryCleaners[ticketNumber];
            this.txClientNameSearch.Text = dryCleaner.Ticket.ClientName;

            foreach (var item in dryCleaner.Items)
            {
                this.lbFoundItems.Items.Add(item.ToString());
            }

            DomainUpDownAddInformation();
        }


        private void btnReturnedItems_Click(object sender, EventArgs e)
        {
            string ticketNumber;
            Regex tickeNumbeRegex;

            try
            {
                tickeNumbeRegex = new Regex("^[0-9]+$");
                ticketNumber = String.Format("{0:0000}", this.domainUpDown.Text);
            }
            catch (Exception)
            {
                // Empty fields
                MessageBox.Show("Empty fields!");
                return;
            }



            if (!tickeNumbeRegex.IsMatch(ticketNumber))
            {
                // Doesn't match the pattern
                MessageBox.Show("Use existing ticket number.");
                return;
            }

            foreach (var item in this.MapTicketDryCleaners[ticketNumber].Items)
            {
                if (this.lbFoundItems.SelectedItem.ToString().Contains(item.Name) && this.lbFoundItems.SelectedItem.ToString().Contains(item.Type.ToString()))
                {
                    this.MapTicketDryCleaners[ticketNumber].Items.Remove(item);
                    this.lbFoundItems.Items.Remove(this.lbFoundItems.SelectedItem);

                    UpdateListInformation(ticketNumber);

                    MessageBox.Show("You successfully remove this item.");
                    return;
                }
            }
        }
    }
}
