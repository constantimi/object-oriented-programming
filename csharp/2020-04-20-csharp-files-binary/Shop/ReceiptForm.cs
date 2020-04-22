using Shop.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class ReceiptForm : Form
    {
        public List<Customer> customers;
        private double currentRevenue;
        public ReceiptForm()
        {
            InitializeComponent();
            this.customers = new List<Customer>();
            this.currentRevenue = 0.00f;
        }


        // Create the receipt as a pdf
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // This prints the reciept

            Graphics graphic = e.Graphics;

            Font fontRegular = new Font("Courier New", 12);
            Font fontItalic = new Font("Courier New", 12, FontStyle.Italic);
            Font headerFont = new Font("Courier New", 18);

            float fontHeight = fontRegular.GetHeight();
            SolidBrush solidBlackColor = new SolidBrush(Color.Black);

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Coffee & Pizza Roasters", headerFont, solidBlackColor, startX, startY);
            float totalprice = 0.00f;

            if (this.listReceipt.Items.Count > 0) { 

                string top = "Item Name".PadRight(30) + "Price";
                graphic.DrawString(top, fontRegular, solidBlackColor, startX, startY + offset);

                offset = offset + (int)fontHeight;
                graphic.DrawString("----------------------------------------", fontRegular, solidBlackColor, startX, startY + offset);
                offset = offset + (int)fontHeight + 5;

               

                foreach (string item in this.listReceipt.Items)
                {
                    // Create the string to print on the reciept
                    string productDescription = item;
                    string productTotal = item.Substring(item.Length - 5, 5);
                    float productPrice = float.Parse(item.Substring(item.Length - 4, 4));

                    // Calculate total price
                    totalprice += productPrice;


                    string productLine = productDescription;

                    graphic.DrawString(productLine, fontRegular, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5;


                }
            }
            
            // When we draw all items add the total

            graphic.DrawString("----------------------------------------", fontRegular, solidBlackColor, startX, startY + offset);

            offset = offset + 20; 

            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), solidBlackColor, startX, startY + offset);
            offset = offset + 30;

            graphic.DrawString("----------------------------------------", fontRegular, solidBlackColor, startX, startY + offset);
            offset = offset + 30;

            graphic.DrawString("ORDER BY " + this.labelCustomer.Text + " " + DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"), fontRegular, solidBlackColor, startX, startY + offset);
            offset = offset + 30;

            graphic.DrawString("     Thank-you for your custom,", fontRegular, solidBlackColor, startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", fontRegular, solidBlackColor, startX, startY + offset);

        }

        // Create the receipt as txt
        private void CreateFile()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Includes\\" + DateTime.UtcNow.AddMinutes(120).ToString("yyyy-MM-dd HHmm") + " " +
                this.labelCustomer.Text + " file.txt");

            sw.WriteLine("Coffee & Pizza Roasters");
            sw.WriteLine("Item Name".PadRight(30) + "Price");
            sw.WriteLine("----------------------------------------");

            float totalprice = 0.00f;

            foreach (string item in this.listReceipt.Items)
            {
                // Create the string to print on the reciept
                string productDescription = item;
                string productTotal = item.Substring(item.Length - 5, 5);
                float productPrice = float.Parse(item.Substring(item.Length - 4, 4));

                // Calculate total price
                totalprice += productPrice;

                string productLine = productDescription.Substring(0, 24);
                sw.WriteLine($"{productLine}".PadRight(30) + String.Format("{0:c}", productPrice));
            }

            sw.WriteLine("----------------------------------------");
            sw.WriteLine("Total to pay ".PadRight(30) + String.Format("{0:c}", totalprice));
            sw.WriteLine("----------------------------------------");

            sw.WriteLine("ORDER BY John " + DateTime.UtcNow.AddMinutes(120).ToString("yyyy-MM-dd HH:mm:ss"));
            sw.WriteLine("     Thank-you for your custom");
            sw.WriteLine("       please come back soon!");
            sw.Close();

            this.currentRevenue += totalprice;

            // Clear the list 
            this.listReceipt.Items.Clear();
        }

        // Buttons
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            CustomersForm cf = new CustomersForm(this);
            cf.Show();
        }
        private void btnFiles_Click(object sender, EventArgs e)
        {
            LoadFilesForm lfs = new LoadFilesForm(this);
            lfs.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add items to the receipt
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (this.comboPizza.SelectedIndex > -1)
            {
                string productName = this.comboPizza.SelectedItem.ToString().Substring(0, this.comboPizza.SelectedItem.ToString().Length - 6);
                string productTotal = this.comboPizza.SelectedItem.ToString().Substring(this.comboPizza.SelectedItem.ToString().Length - 6, 6);

                this.listReceipt.Items.Add(productName.PadRight(30) + productTotal);
            }
        }

        // Remove items from the receipt
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                this.listReceipt.Items.RemoveAt(this.listReceipt.SelectedIndex);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Add the document to the dialog box        
            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); // Add an event handler that will do the printing

            // Choose where to print
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }

            // Create text file
            CreateFile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.listReceipt.Items.Clear();
        }
        public void UpdateInformationCustomers(string name)
        {
            this.labelCustomer.Text = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateFile();
            MessageBox.Show("The receipt is saved!");
        }

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            if (this.comboDrinks.SelectedIndex > -1)
            {
                string productName = this.comboDrinks.SelectedItem.ToString().Substring(0, this.comboDrinks.SelectedItem.ToString().Length - 6);
                string productTotal = this.comboDrinks.SelectedItem.ToString().Substring(this.comboDrinks.SelectedItem.ToString().Length - 6, 6);

                this.listReceipt.Items.Add(productName.PadRight(30) + productTotal);
            }
        }
        
        private void btnHistory_Click(object sender, EventArgs e)
        {
            RevenueForm rf = new RevenueForm(this, this.currentRevenue);
            rf.Show();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReadWriteBinary rwb = new ReadWriteBinary();
            rwb.SaveCurrentDate(DateTime.UtcNow.ToString("yyyy-MM-dd"), this.currentRevenue);
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

        private void btnHistory_MouseEnter(object sender, EventArgs e)
        {
            this.btnHistory.BackColor = Color.LightGray;
        }
        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            this.btnHistory.BackColor = Color.White;
        }

        private void btnAccounts_MouseEnter(object sender, EventArgs e)
        {
            this.btnAccounts.BackColor = Color.LightGray;
        }
        private void btnAccounts_MouseLeave(object sender, EventArgs e)
        {
            this.btnAccounts.BackColor = Color.White;
        }

        private void btnFile_MouseEnter(object sender, EventArgs e)
        {
            this.btnFiles.BackColor = Color.LightGray;
        }
        private void btnFile_MouseLeave(object sender, EventArgs e)
        {
            this.btnFiles.BackColor = Color.White;
        }
        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            this.btnLoad.BackColor = Color.LightGray;
        }
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            this.btnLoad.BackColor = Color.White;
        }

        // Timer

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.UtcNow.AddMinutes(120).ToString("yyyy-MM-dd HH:mm:ss");
        }

        
        
    }
}
