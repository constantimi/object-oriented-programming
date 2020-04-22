using Shop.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class RevenueForm : Form
    {
        private double revenue;
        private ReceiptForm receiptForm;
        private ReadWriteBinary rwb;
        public RevenueForm(ReceiptForm receiptForm, double revenue)
        {
            InitializeComponent();
            this.receiptForm = receiptForm;
            this.revenue = revenue;
            UpdateInformation(DateTime.UtcNow);
        }

        private void UpdateInformation(DateTime date)
        {
            this.rwb = new ReadWriteBinary();

            this.labelInformation.Text = this.rwb.ShowPreviousTime(date.ToString("yyyy-MM-dd"));
        }

        // Buttons
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            UpdateInformation(this.dateTimePicker.Value);
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

        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            this.btnLoad.BackColor = Color.LightGray;
        }
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            this.btnLoad.BackColor = Color.White;
        }

        
    }
}
