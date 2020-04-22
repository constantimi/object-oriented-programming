using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shop
{
    public partial class LoadFilesForm : Form
    {
        private ReceiptForm receiptForm;
        public LoadFilesForm(ReceiptForm rf)
        {
            InitializeComponent();
            ShowInfo();
            this.receiptForm = rf;
        }

        // Additional methods
        private void ShowInfo()
        {
            this.listLoadFiles.Items.Clear();
            string[] files = Directory.GetFiles(Application.StartupPath + "\\Includes\\");

            foreach (string file in files)
            {
                this.listLoadFiles.Items.Add(Path.GetFileName(file));
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.listLoadFiles.SelectedIndex > -1)
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Includes\\" + this.listLoadFiles.SelectedItem);
                this.textInformation.Text = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                this.textInformation.Text = "";
            }
        }

        // Buttons
        private void btExit_Click(object sender, EventArgs e)
        {
            receiptForm.Close();
            this.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
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
    }
}
