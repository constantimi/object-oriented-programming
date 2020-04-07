using System;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace Search
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = openFileDialog.OpenFile()) != null)
                {
                    string strfilename = openFileDialog.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    this.richTextBox.Text = filetext;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = 0;            

            // Reset searching 
            this.richTextBox.SelectAll();
            this.richTextBox.SelectionBackColor = Color.White;

     
            while (index < this.richTextBox.Text.LastIndexOf(this.searchField.Text))
            {
                // Searches the text
                this.richTextBox.Find(this.searchField.Text, index, this.richTextBox.TextLength, RichTextBoxFinds.MatchCase);

                // Selection Color
                this.richTextBox.SelectionBackColor = Color.Yellow;

                // Increment 
                index = this.richTextBox.Text.IndexOf(this.searchField.Text, index) + 1;
            }
            
        }
    }
}
