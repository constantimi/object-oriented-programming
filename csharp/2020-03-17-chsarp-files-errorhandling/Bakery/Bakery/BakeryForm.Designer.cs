namespace Bakery
{
    partial class BakeryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSandwichFinished = new System.Windows.Forms.Button();
            this.btAddIngredient = new System.Windows.Forms.Button();
            this.cbIngredients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddBread = new System.Windows.Forms.Button();
            this.cbBreadTypes = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSandwiches = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSandwichNameAndPrice = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.btCreatePriceList = new System.Windows.Forms.Button();
            this.btSaveSandwiches = new System.Windows.Forms.Button();
            this.btLoadSandwiches = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSandwichFinished);
            this.groupBox1.Controls.Add(this.btAddIngredient);
            this.groupBox1.Controls.Add(this.cbIngredients);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btAddBread);
            this.groupBox1.Controls.Add(this.cbBreadTypes);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(273, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Sandwich";
            // 
            // btSandwichFinished
            // 
            this.btSandwichFinished.Location = new System.Drawing.Point(139, 191);
            this.btSandwichFinished.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSandwichFinished.Name = "btSandwichFinished";
            this.btSandwichFinished.Size = new System.Drawing.Size(129, 70);
            this.btSandwichFinished.TabIndex = 8;
            this.btSandwichFinished.Text = "Sandwich Finished";
            this.btSandwichFinished.UseVisualStyleBackColor = true;
            this.btSandwichFinished.Click += new System.EventHandler(this.btSandwichFinished_Click);
            // 
            // btAddIngredient
            // 
            this.btAddIngredient.Location = new System.Drawing.Point(5, 191);
            this.btAddIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddIngredient.Name = "btAddIngredient";
            this.btAddIngredient.Size = new System.Drawing.Size(116, 70);
            this.btAddIngredient.TabIndex = 7;
            this.btAddIngredient.Text = "Add Ingredient";
            this.btAddIngredient.UseVisualStyleBackColor = true;
            this.btAddIngredient.Click += new System.EventHandler(this.btAddIngredient_Click);
            // 
            // cbIngredients
            // 
            this.cbIngredients.FormattingEnabled = true;
            this.cbIngredients.Location = new System.Drawing.Point(87, 146);
            this.cbIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIngredients.Name = "cbIngredients";
            this.cbIngredients.Size = new System.Drawing.Size(169, 26);
            this.cbIngredients.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingredient";
            // 
            // btAddBread
            // 
            this.btAddBread.Location = new System.Drawing.Point(52, 105);
            this.btAddBread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddBread.Name = "btAddBread";
            this.btAddBread.Size = new System.Drawing.Size(161, 28);
            this.btAddBread.TabIndex = 4;
            this.btAddBread.Text = "Add Bread";
            this.btAddBread.UseVisualStyleBackColor = true;
            this.btAddBread.Click += new System.EventHandler(this.btAddBread_Click);
            // 
            // cbBreadTypes
            // 
            this.cbBreadTypes.FormattingEnabled = true;
            this.cbBreadTypes.Location = new System.Drawing.Point(87, 66);
            this.cbBreadTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBreadTypes.Name = "cbBreadTypes";
            this.cbBreadTypes.Size = new System.Drawing.Size(169, 26);
            this.cbBreadTypes.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(87, 34);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 26);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bread Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lbSandwiches
            // 
            this.lbSandwiches.FormattingEnabled = true;
            this.lbSandwiches.ItemHeight = 18;
            this.lbSandwiches.Location = new System.Drawing.Point(300, 24);
            this.lbSandwiches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbSandwiches.Name = "lbSandwiches";
            this.lbSandwiches.Size = new System.Drawing.Size(248, 508);
            this.lbSandwiches.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sandwich Information:";
            // 
            // lblSandwichNameAndPrice
            // 
            this.lblSandwichNameAndPrice.AutoSize = true;
            this.lblSandwichNameAndPrice.Location = new System.Drawing.Point(573, 59);
            this.lblSandwichNameAndPrice.Name = "lblSandwichNameAndPrice";
            this.lblSandwichNameAndPrice.Size = new System.Drawing.Size(24, 18);
            this.lblSandwichNameAndPrice.TabIndex = 3;
            this.lblSandwichNameAndPrice.Text = "....";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(573, 77);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(24, 18);
            this.lblIngredients.TabIndex = 4;
            this.lblIngredients.Text = "....";
            // 
            // btCreatePriceList
            // 
            this.btCreatePriceList.Location = new System.Drawing.Point(563, 402);
            this.btCreatePriceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreatePriceList.Name = "btCreatePriceList";
            this.btCreatePriceList.Size = new System.Drawing.Size(242, 54);
            this.btCreatePriceList.TabIndex = 5;
            this.btCreatePriceList.Text = "Create Pricelist";
            this.btCreatePriceList.UseVisualStyleBackColor = true;
            this.btCreatePriceList.Click += new System.EventHandler(this.btCreatePriceList_Click);
            // 
            // btSaveSandwiches
            // 
            this.btSaveSandwiches.Location = new System.Drawing.Point(563, 471);
            this.btSaveSandwiches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaveSandwiches.Name = "btSaveSandwiches";
            this.btSaveSandwiches.Size = new System.Drawing.Size(114, 61);
            this.btSaveSandwiches.TabIndex = 6;
            this.btSaveSandwiches.Text = "Save Sandwiches";
            this.btSaveSandwiches.UseVisualStyleBackColor = true;
            this.btSaveSandwiches.Click += new System.EventHandler(this.btSaveSandwiches_Click);
            // 
            // btLoadSandwiches
            // 
            this.btLoadSandwiches.Location = new System.Drawing.Point(692, 471);
            this.btLoadSandwiches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLoadSandwiches.Name = "btLoadSandwiches";
            this.btLoadSandwiches.Size = new System.Drawing.Size(112, 61);
            this.btLoadSandwiches.TabIndex = 7;
            this.btLoadSandwiches.Text = "Load Sandwiches";
            this.btLoadSandwiches.UseVisualStyleBackColor = true;
            this.btLoadSandwiches.Click += new System.EventHandler(this.btLoadSandwiches_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BakeryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 543);
            this.Controls.Add(this.btLoadSandwiches);
            this.Controls.Add(this.btSaveSandwiches);
            this.Controls.Add(this.btCreatePriceList);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblSandwichNameAndPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSandwiches);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BakeryForm";
            this.Text = "Bakery";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSandwichFinished;
        private System.Windows.Forms.Button btAddIngredient;
        private System.Windows.Forms.ComboBox cbIngredients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddBread;
        private System.Windows.Forms.ComboBox cbBreadTypes;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSandwiches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSandwichNameAndPrice;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btCreatePriceList;
        private System.Windows.Forms.Button btSaveSandwiches;
        private System.Windows.Forms.Button btLoadSandwiches;
        private System.Windows.Forms.Timer timer;
    }
}

