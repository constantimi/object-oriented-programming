using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LinkedListAssignment
{
    public partial class LinkedListForm : Form
    {
        private LinkedList<String> linkedList;
        public LinkedListForm()
        {
            InitializeComponent();
            this.linkedList = new LinkedList<String>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name = (String)this.txNewName.Text;

            this.linkedList.AddLast(name);

            showInformation();
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            String name = (String)this.txNewName.Text;

            if (!this.linkedList.Remove(name))
            {
                MessageBox.Show("This name doesn't exist");
            }

            showInformation();
        }

        private void btnSelectNameByIndex_Click(object sender, EventArgs e)
        {
            int index = System.Math.Abs((int) this.domainNamesIndex.SelectedIndex) < this.linkedList.Count ? System.Math.Abs((int)this.domainNamesIndex.SelectedIndex) : 0;

            

            this.listboxNames.Items.Clear();
            try
            {
                this.listboxNames.Items.Add(this.linkedList.ElementAt(index));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Doesn't contain elements!");
            }
            
        }

        private void showInformation()
        {
            this.listboxNames.Items.Clear();
            this.domainNamesIndex.Items.Clear();

            int count = 0;
            foreach (string str in this.linkedList)
            {
                this.listboxNames.Items.Add(str);
                this.domainNamesIndex.Items.Add(count++);
            }

            this.domainNamesIndex.Text = Convert.ToString(this.linkedList.Count());
            this.lbAmount.Text = Convert.ToString(this.linkedList.Count());
        }
    }
}
