using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shop
{
    public partial class CustomersForm : Form
    {
      
        private ReceiptForm receiptForm;
        private int seeder;

        public CustomersForm(ReceiptForm receiptForm)
        {
            InitializeComponent();

            this.seeder = 0;
            this.receiptForm = receiptForm;

            updateInformation();
        }


        /// Email validation
        private bool isEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("The Email is invalid!");
            }

            return false;
        }

        /// Validate the name
        private bool isNameValid(string name)
        {
            Regex rx = new Regex(@"^[A-Z][a-zA-Z]*$");

            if (!rx.IsMatch(name))
            {
                MessageBox.Show("The Name is invalid! Only \"A-Z\" \"a-z\" characters, at least one uppercase letter");
                return false;
            }

            return true;
        }

        // Update information
        private void updateInformation()
        {
            foreach (Customer customer in receiptForm.customers)
            {
                this.seeder++;
                this.dataGridView.Rows.Add(customer.Id, customer.Name, customer.Email);
            }

        }

        private void addCustomer(Customer customer)
        {
            Boolean addCustomer = true;

            foreach (Customer c in receiptForm.customers)
            {
                if (c.Name == customer.Name)
                {
                    addCustomer = false;
                }
            }

            if (addCustomer)
            {
                receiptForm.customers.Add(customer);
                this.seeder++;
                this.dataGridView.Rows.Add(customer.Id, customer.Name, customer.Email);
            }

            addCustomer = true;
        }


        /// Buttons
        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string name = this.tbName.Text;
            string email = this.tbEmail.Text;
            string id = Convert.ToString(this.seeder);

            if (isNameValid(name))
            {
                try
                {
                    if (email.Length > 0)
                    {
                        if (isEmailValid(email))
                        {
                            customer = new Customer(id, name, email);
                            addCustomer(customer);
                        }
                    }
                    else
                    {
                        customer = new Customer(id, name);
                        addCustomer(customer);
                    }

                }
                catch (Exception ex)
                {
                    // Extract some information from this exception, and then
                    // throw it to the parent method.
                    if (ex.Source != null)
                    {
                        System.ArgumentException argEx = new System.ArgumentException("Wrong input information", "customer", ex);

                        throw argEx;
                    }
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            receiptForm.Close();
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            receiptForm.UpdateInformationCustomers("Anonymouse");
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                String name = Convert.ToString(dataGridView.Rows[item.Index].Cells[1].Value);
                Customer customer = this.receiptForm.customers.Find(x => name == x.Name);
                receiptForm.customers.Remove(customer);
               
                this.dataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView.CurrentCell.RowIndex;
                String name = Convert.ToString(dataGridView.Rows[index].Cells[1].Value);
                receiptForm.UpdateInformationCustomers(name);
            }
            catch (Exception)
            {

            }

            this.Close();
        }

        // Hovering onn the the images
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.LightGray;
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.White;
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            this.btnBack.BackColor = Color.LightGray;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            this.btnBack.BackColor = Color.White;
        }

        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            this.btnAddCustomer.BackColor = Color.LightGray;
        }
        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            this.btnAddCustomer.BackColor = Color.Gray;
        }

        private void btnAddSelect_MouseEnter(object sender, EventArgs e)
        {
            this.btnUser.BackColor = Color.LightGray;
        }
        private void btnAddSelect_MouseLeave(object sender, EventArgs e)
        {
            this.btnUser.BackColor = Color.Gray;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            this.btnDelete.BackColor = Color.LightGray;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            this.btnDelete.BackColor = Color.White;
        }
    }
}
