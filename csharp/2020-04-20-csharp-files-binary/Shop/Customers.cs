using Shop.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Customers : Form
    {
        // Properties
        private List<Customer> customers;

        public Customers()
        {
            InitializeComponent();
            this.customers = new List<Customer>();
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


        /// Buttons
        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string name = this.tbName.Text;
            string email = this.tbEmail.Text;

            if (isNameValid(name))
            {
                try
                {
                    if (email.Length > 0)
                    {
                        if (isEmailValid(email))
                        {
                            customer = new Customer(name, email);
                        }
                    }
                    else
                    {
                        customer = new Customer(name);
                    }

                    this.customers.Add(customer);
                }
                catch (Exception ex)
                {
                    // Extract some information from this exception, and then
                    // throw it to the parent method.
                    if (ex.Source != null)
                    {
                        System.ArgumentException argEx = new System.ArgumentException("Wrong input information", "customer", ex);

                        LogExceptions exceptions = new LogExceptions(argEx);
                        throw argEx;
                    }
                }
            }
        }
    }
}
