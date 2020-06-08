using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAssignment
{
    public partial class StackForm : Form
    {
        private ActionManager actionManager;
        private string method;
        private Text text;
        public StackForm()
        {
            InitializeComponent();
            this.actionManager = new ActionManager();
            this.text = new Text();
            this.method = null;
        }

        private void showInformation()
        {
            this.listOfLines.Items.Clear();
            this.domainAdd.Items.Clear();
            this.domainAdd.Items.Clear();

            int count = 0;
            foreach (String line in this.text.GetText())
            {
                this.listOfLines.Items.Add(line);
                this.domainAdd.Items.Add(count);
                this.domainRemove.Items.Add(count);
                count += 1;
            }

            count  -= 1;
            this.domainAdd.Text = count.ToString();
            this.domainRemove.Text = count.ToString();
        }

        private void btnAddLineToEnd_Click(object sender, EventArgs e)
        {
            string line = this.txLine.Text;

            LineToEndAction lineToEnd = new LineToEndAction(line, this.text);
            this.actionManager.Do(lineToEnd, "Add");
            this.method = "Add";
            showInformation();
        }

        private void btnInsertLine_Click(object sender, EventArgs e)
        {
            string line = this.txLine.Text;
            int index = Convert.ToInt32(domainAdd.Text);

            LineInsertAction lineInsert = new LineInsertAction(line, index, this.text);
            this.actionManager.Do(lineInsert, "Insert");
            this.method = "Insert";
            showInformation();
        }

        private void btnRemoveLastLine_Click(object sender, EventArgs e)
        {
            string line = this.txLine.Text;
            int index = Convert.ToInt32(domainRemove.Text);

            LineToEndAction lineToEndAction = new LineToEndAction(line, this.text);
            this.actionManager.Do(lineToEndAction, "Remove");
            this.method = "Remove";
            showInformation();
        }

        private void btnRemoveLineFrom_Click(object sender, EventArgs e)
        {
            string line = this.txLine.Text;
            int index = Convert.ToInt32(domainAdd.Text);

            LineInsertAction lineInsertAction = new LineInsertAction(line, index, this.text);
            this.actionManager.Do(lineInsertAction, "RemoveIndex");
            this.method = "RemoveIndex";
            showInformation();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (this.method == null)
            {
                MessageBox.Show("There is no action");
                return;
            }

            this.actionManager.Undo(this.method);
            showInformation();
        }
    }
}
