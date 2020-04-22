namespace Shop
{
    partial class ReceiptForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.listReceipt = new System.Windows.Forms.ListBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPizza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDrinks = new System.Windows.Forms.ComboBox();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddDrinks = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.PictureBox();
            this.btnAccounts = new System.Windows.Forms.PictureBox();
            this.btnFiles = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(841, 192);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 80);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Location = new System.Drawing.Point(841, 82);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(91, 80);
            this.btnReceipt.TabIndex = 28;
            this.btnReceipt.Text = "Print Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // listReceipt
            // 
            this.listReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReceipt.FormattingEnabled = true;
            this.listReceipt.ItemHeight = 18;
            this.listReceipt.Location = new System.Drawing.Point(407, 99);
            this.listReceipt.Name = "listReceipt";
            this.listReceipt.Size = new System.Drawing.Size(401, 472);
            this.listReceipt.TabIndex = 30;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(39, 12);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(82, 20);
            this.labelCustomer.TabIndex = 40;
            this.labelCustomer.Text = "Customer";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(841, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 80);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Files";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(841, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 80);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Choose Pizza";
            // 
            // comboPizza
            // 
            this.comboPizza.DropDownHeight = 50;
            this.comboPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPizza.FormattingEnabled = true;
            this.comboPizza.IntegralHeight = false;
            this.comboPizza.Items.AddRange(new object[] {
            "Pizza margherita €5,99",
            "Pizza margherita - thick €6,50",
            "Pizza margherita - filled €7,95",
            "Pizza quattro formaggi €7,99",
            "Pizza quattro formaggi - thick €8,50",
            "Pizza quattro formaggi - filled €9,95",
            "Pizza quattro stagioni €7,49",
            "Pizza quattro stagioni - thick €6,00",
            "Pizza quattro stagioni - filled €7,45",
            "Pizza pepperoni €6,99",
            "Pizza pepperoni - thick €7,50",
            "Pizza pepperoni - filled €8,95",
            "Pizza BBQ chicken €6,99",
            "Pizza BBQ chicken - thick €7,50",
            "Pizza BBQ chicken - filled €8,95"});
            this.comboPizza.Location = new System.Drawing.Point(16, 48);
            this.comboPizza.Name = "comboPizza";
            this.comboPizza.Size = new System.Drawing.Size(283, 26);
            this.comboPizza.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "Choose Drinks";
            // 
            // comboDrinks
            // 
            this.comboDrinks.DropDownHeight = 50;
            this.comboDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDrinks.FormattingEnabled = true;
            this.comboDrinks.IntegralHeight = false;
            this.comboDrinks.Items.AddRange(new object[] {
            "Flat water €2,50",
            "Sparkling water  €2,50",
            "Cola €2,75",
            "Ice tea €2,75",
            "Energy drink €3,75 "});
            this.comboDrinks.Location = new System.Drawing.Point(16, 48);
            this.comboDrinks.Name = "comboDrinks";
            this.comboDrinks.Size = new System.Drawing.Size(283, 26);
            this.comboDrinks.TabIndex = 47;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAddPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPizza.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.btnAddPizza.ForeColor = System.Drawing.Color.White;
            this.btnAddPizza.Location = new System.Drawing.Point(124, 101);
            this.btnAddPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(175, 37);
            this.btnAddPizza.TabIndex = 49;
            this.btnAddPizza.Text = "Add Item";
            this.btnAddPizza.UseVisualStyleBackColor = false;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddPizza);
            this.panel1.Controls.Add(this.comboPizza);
            this.panel1.Location = new System.Drawing.Point(56, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 162);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddDrinks);
            this.panel2.Controls.Add(this.comboDrinks);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(56, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 156);
            this.panel2.TabIndex = 51;
            // 
            // btnAddDrinks
            // 
            this.btnAddDrinks.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAddDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrinks.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.btnAddDrinks.ForeColor = System.Drawing.Color.White;
            this.btnAddDrinks.Location = new System.Drawing.Point(124, 93);
            this.btnAddDrinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDrinks.Name = "btnAddDrinks";
            this.btnAddDrinks.Size = new System.Drawing.Size(175, 37);
            this.btnAddDrinks.TabIndex = 50;
            this.btnAddDrinks.Text = "Add Item";
            this.btnAddDrinks.UseVisualStyleBackColor = false;
            this.btnAddDrinks.Click += new System.EventHandler(this.btnAddDrinks_Click);
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Controls.Add(this.labelCustomer);
            this.panelTime.Location = new System.Drawing.Point(309, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(352, 44);
            this.panelTime.TabIndex = 51;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(163, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(64, 17);
            this.labelTime.TabIndex = 53;
            this.labelTime.Text = "12:30:33";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "History";
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.ErrorImage = global::Shop.Properties.Resources.settings;
            this.btnHistory.Image = global::Shop.Properties.Resources.settings;
            this.btnHistory.InitialImage = global::Shop.Properties.Resources.settings;
            this.btnHistory.Location = new System.Drawing.Point(171, 11);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(35, 35);
            this.btnHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHistory.TabIndex = 52;
            this.btnHistory.TabStop = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.btnHistory_MouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.btnHistory_MouseLeave);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccounts.ErrorImage = global::Shop.Properties.Resources.user;
            this.btnAccounts.Image = global::Shop.Properties.Resources.user1;
            this.btnAccounts.InitialImage = global::Shop.Properties.Resources.user;
            this.btnAccounts.Location = new System.Drawing.Point(28, 11);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(35, 35);
            this.btnAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccounts.TabIndex = 39;
            this.btnAccounts.TabStop = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            this.btnAccounts.MouseEnter += new System.EventHandler(this.btnAccounts_MouseEnter);
            this.btnAccounts.MouseLeave += new System.EventHandler(this.btnAccounts_MouseLeave);
            // 
            // btnFiles
            // 
            this.btnFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiles.ErrorImage = global::Shop.Properties.Resources.folder;
            this.btnFiles.Image = global::Shop.Properties.Resources.folder;
            this.btnFiles.InitialImage = global::Shop.Properties.Resources.folder;
            this.btnFiles.Location = new System.Drawing.Point(99, 11);
            this.btnFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(35, 35);
            this.btnFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFiles.TabIndex = 38;
            this.btnFiles.TabStop = false;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            this.btnFiles.MouseEnter += new System.EventHandler(this.btnFile_MouseEnter);
            this.btnFiles.MouseLeave += new System.EventHandler(this.btnFile_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImage")));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExit.InitialImage")));
            this.btnExit.Location = new System.Drawing.Point(953, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 26;
            this.btnExit.TabStop = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(841, 523);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 80);
            this.btnLoad.TabIndex = 51;
            this.btnLoad.Text = "Load Revenue";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.MouseEnter += new System.EventHandler(this.btnLoad_MouseEnter);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_MouseLeave);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnFiles);
            this.Controls.Add(this.listReceipt);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReceiptForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.ListBox listReceipt;
        private System.Windows.Forms.PictureBox btnFiles;
        private System.Windows.Forms.PictureBox btnAccounts;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDrinks;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddDrinks;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnHistory;
        private System.Windows.Forms.Button btnLoad;
    }
}