namespace MapAssignment
{
    partial class FormMap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturnedItems = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txClientNameSearch = new System.Windows.Forms.TextBox();
            this.lbFoundItems = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txClientName = new System.Windows.Forms.TextBox();
            this.txTicketNumber = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txItemName = new System.Windows.Forms.TextBox();
            this.radioShoeRepair = new System.Windows.Forms.RadioButton();
            this.radioDryCleaning = new System.Windows.Forms.RadioButton();
            this.radioLaundry = new System.Windows.Forms.RadioButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.domainUpDown);
            this.panel2.Controls.Add(this.btnReturnedItems);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txClientNameSearch);
            this.panel2.Controls.Add(this.lbFoundItems);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(500, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 541);
            this.panel2.TabIndex = 1;
            // 
            // btnReturnedItems
            // 
            this.btnReturnedItems.Location = new System.Drawing.Point(13, 494);
            this.btnReturnedItems.Name = "btnReturnedItems";
            this.btnReturnedItems.Size = new System.Drawing.Size(412, 32);
            this.btnReturnedItems.TabIndex = 12;
            this.btnReturnedItems.Text = "Return Items";
            this.btnReturnedItems.UseVisualStyleBackColor = true;
            this.btnReturnedItems.Click += new System.EventHandler(this.btnReturnedItems_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search ticket";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ticket number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Client name:";
            // 
            // txClientNameSearch
            // 
            this.txClientNameSearch.Location = new System.Drawing.Point(121, 152);
            this.txClientNameSearch.Name = "txClientNameSearch";
            this.txClientNameSearch.Size = new System.Drawing.Size(304, 27);
            this.txClientNameSearch.TabIndex = 7;
            // 
            // lbFoundItems
            // 
            this.lbFoundItems.FormattingEnabled = true;
            this.lbFoundItems.ItemHeight = 20;
            this.lbFoundItems.Location = new System.Drawing.Point(14, 204);
            this.lbFoundItems.Name = "lbFoundItems";
            this.lbFoundItems.Size = new System.Drawing.Size(411, 284);
            this.lbFoundItems.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreateTicket);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txClientName);
            this.panel1.Controls.Add(this.txTicketNumber);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbItems);
            this.panel1.Location = new System.Drawing.Point(32, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 541);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(12, 494);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(412, 32);
            this.btnCreateTicket.TabIndex = 11;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Client name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ticket number:";
            // 
            // txClientName
            // 
            this.txClientName.Location = new System.Drawing.Point(143, 72);
            this.txClientName.Name = "txClientName";
            this.txClientName.Size = new System.Drawing.Size(277, 27);
            this.txClientName.TabIndex = 3;
            // 
            // txTicketNumber
            // 
            this.txTicketNumber.Location = new System.Drawing.Point(143, 21);
            this.txTicketNumber.Name = "txTicketNumber";
            this.txTicketNumber.Size = new System.Drawing.Size(277, 27);
            this.txTicketNumber.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txItemName);
            this.panel3.Controls.Add(this.radioShoeRepair);
            this.panel3.Controls.Add(this.radioDryCleaning);
            this.panel3.Controls.Add(this.radioLaundry);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Location = new System.Drawing.Point(12, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 116);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item name:";
            // 
            // txItemName
            // 
            this.txItemName.Location = new System.Drawing.Point(121, 45);
            this.txItemName.Name = "txItemName";
            this.txItemName.Size = new System.Drawing.Size(265, 27);
            this.txItemName.TabIndex = 4;
            // 
            // radioShoeRepair
            // 
            this.radioShoeRepair.AutoSize = true;
            this.radioShoeRepair.Location = new System.Drawing.Point(261, 15);
            this.radioShoeRepair.Name = "radioShoeRepair";
            this.radioShoeRepair.Size = new System.Drawing.Size(116, 24);
            this.radioShoeRepair.TabIndex = 5;
            this.radioShoeRepair.Text = "Shoe repair";
            this.radioShoeRepair.UseVisualStyleBackColor = true;
            // 
            // radioDryCleaning
            // 
            this.radioDryCleaning.AutoSize = true;
            this.radioDryCleaning.Location = new System.Drawing.Point(130, 15);
            this.radioDryCleaning.Name = "radioDryCleaning";
            this.radioDryCleaning.Size = new System.Drawing.Size(124, 24);
            this.radioDryCleaning.TabIndex = 4;
            this.radioDryCleaning.Text = "Dry cleaning";
            this.radioDryCleaning.UseVisualStyleBackColor = true;
            // 
            // radioLaundry
            // 
            this.radioLaundry.AutoSize = true;
            this.radioLaundry.Checked = true;
            this.radioLaundry.Location = new System.Drawing.Point(21, 15);
            this.radioLaundry.Name = "radioLaundry";
            this.radioLaundry.Size = new System.Drawing.Size(90, 24);
            this.radioLaundry.TabIndex = 3;
            this.radioLaundry.TabStop = true;
            this.radioLaundry.Text = "Laundry";
            this.radioLaundry.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(21, 79);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(365, 32);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(12, 284);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(411, 204);
            this.lbItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ticket Retrieval";
            // 
            // domainUpDown
            // 
            this.domainUpDown.Location = new System.Drawing.Point(135, 26);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.Size = new System.Drawing.Size(166, 27);
            this.domainUpDown.TabIndex = 13;
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMap";
            this.Text = "Dry Cleaner";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txClientNameSearch;
        private System.Windows.Forms.ListBox lbFoundItems;
        private System.Windows.Forms.TextBox txClientName;
        private System.Windows.Forms.TextBox txTicketNumber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txItemName;
        private System.Windows.Forms.RadioButton radioShoeRepair;
        private System.Windows.Forms.RadioButton radioDryCleaning;
        private System.Windows.Forms.RadioButton radioLaundry;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturnedItems;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.DomainUpDown domainUpDown;
    }
}

