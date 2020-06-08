namespace LinkedListAssignment
{
    partial class LinkedListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listboxNames = new System.Windows.Forms.ListBox();
            this.btnSelectNameByIndex = new System.Windows.Forms.Button();
            this.domainNamesIndex = new System.Windows.Forms.DomainUpDown();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.txNewName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listboxNames
            // 
            this.listboxNames.FormattingEnabled = true;
            this.listboxNames.ItemHeight = 18;
            this.listboxNames.Location = new System.Drawing.Point(432, 11);
            this.listboxNames.Name = "listboxNames";
            this.listboxNames.Size = new System.Drawing.Size(341, 382);
            this.listboxNames.TabIndex = 0;
            // 
            // btnSelectNameByIndex
            // 
            this.btnSelectNameByIndex.Location = new System.Drawing.Point(178, 162);
            this.btnSelectNameByIndex.Name = "btnSelectNameByIndex";
            this.btnSelectNameByIndex.Size = new System.Drawing.Size(211, 27);
            this.btnSelectNameByIndex.TabIndex = 1;
            this.btnSelectNameByIndex.Text = "Select Name By Index";
            this.btnSelectNameByIndex.UseVisualStyleBackColor = true;
            this.btnSelectNameByIndex.Click += new System.EventHandler(this.btnSelectNameByIndex_Click);
            // 
            // domainNamesIndex
            // 
            this.domainNamesIndex.Location = new System.Drawing.Point(32, 164);
            this.domainNamesIndex.Name = "domainNamesIndex";
            this.domainNamesIndex.Size = new System.Drawing.Size(140, 24);
            this.domainNamesIndex.TabIndex = 2;
            this.domainNamesIndex.Text = "1";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(33, 224);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(148, 18);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Amount of elements: ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(29, 32);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(52, 18);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "Name:";
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(178, 79);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(211, 27);
            this.btnRemoveName.TabIndex = 5;
            this.btnRemoveName.Text = "Remove name";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(175, 224);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(16, 18);
            this.lbAmount.TabIndex = 7;
            this.lbAmount.Text = "0";
            // 
            // txNewName
            // 
            this.txNewName.Location = new System.Drawing.Point(108, 30);
            this.txNewName.Name = "txNewName";
            this.txNewName.Size = new System.Drawing.Size(281, 24);
            this.txNewName.TabIndex = 8;
            // 
            // LinkedListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 408);
            this.Controls.Add(this.txNewName);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemoveName);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.domainNamesIndex);
            this.Controls.Add(this.btnSelectNameByIndex);
            this.Controls.Add(this.listboxNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LinkedListForm";
            this.Text = "User List Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxNames;
        private System.Windows.Forms.Button btnSelectNameByIndex;
        private System.Windows.Forms.DomainUpDown domainNamesIndex;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txNewName;
    }
}

