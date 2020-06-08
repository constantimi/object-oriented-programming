namespace StackAssignment
{
    partial class StackForm
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
            this.listOfLines = new System.Windows.Forms.ListBox();
            this.btnAddLineToEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domainAdd = new System.Windows.Forms.DomainUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txLine = new System.Windows.Forms.TextBox();
            this.btnInsertLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveLineFrom = new System.Windows.Forms.Button();
            this.domainRemove = new System.Windows.Forms.DomainUpDown();
            this.btnRemoveLastLine = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.Action = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfLines
            // 
            this.listOfLines.FormattingEnabled = true;
            this.listOfLines.ItemHeight = 18;
            this.listOfLines.Location = new System.Drawing.Point(417, 17);
            this.listOfLines.Name = "listOfLines";
            this.listOfLines.Size = new System.Drawing.Size(530, 472);
            this.listOfLines.TabIndex = 0;
            // 
            // btnAddLineToEnd
            // 
            this.btnAddLineToEnd.Location = new System.Drawing.Point(27, 93);
            this.btnAddLineToEnd.Name = "btnAddLineToEnd";
            this.btnAddLineToEnd.Size = new System.Drawing.Size(125, 30);
            this.btnAddLineToEnd.TabIndex = 1;
            this.btnAddLineToEnd.Text = "Add Line to End";
            this.btnAddLineToEnd.UseVisualStyleBackColor = true;
            this.btnAddLineToEnd.Click += new System.EventHandler(this.btnAddLineToEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Line:";
            // 
            // domainAdd
            // 
            this.domainAdd.Location = new System.Drawing.Point(214, 62);
            this.domainAdd.Name = "domainAdd";
            this.domainAdd.Size = new System.Drawing.Size(135, 24);
            this.domainAdd.TabIndex = 3;
            this.domainAdd.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRemoveLineFrom);
            this.panel1.Controls.Add(this.domainRemove);
            this.panel1.Controls.Add(this.btnRemoveLastLine);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnInsertLine);
            this.panel1.Controls.Add(this.domainAdd);
            this.panel1.Controls.Add(this.txLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddLineToEnd);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 281);
            this.panel1.TabIndex = 4;
            // 
            // txLine
            // 
            this.txLine.Location = new System.Drawing.Point(82, 14);
            this.txLine.Name = "txLine";
            this.txLine.Size = new System.Drawing.Size(257, 24);
            this.txLine.TabIndex = 3;
            // 
            // btnInsertLine
            // 
            this.btnInsertLine.Location = new System.Drawing.Point(224, 93);
            this.btnInsertLine.Name = "btnInsertLine";
            this.btnInsertLine.Size = new System.Drawing.Size(125, 30);
            this.btnInsertLine.TabIndex = 4;
            this.btnInsertLine.Text = "Insert Line";
            this.btnInsertLine.UseVisualStyleBackColor = true;
            this.btnInsertLine.Click += new System.EventHandler(this.btnInsertLine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Line number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line number:";
            // 
            // btnRemoveLineFrom
            // 
            this.btnRemoveLineFrom.Location = new System.Drawing.Point(205, 174);
            this.btnRemoveLineFrom.Name = "btnRemoveLineFrom";
            this.btnRemoveLineFrom.Size = new System.Drawing.Size(144, 30);
            this.btnRemoveLineFrom.TabIndex = 8;
            this.btnRemoveLineFrom.Text = "Remove Line from";
            this.btnRemoveLineFrom.UseVisualStyleBackColor = true;
            this.btnRemoveLineFrom.Click += new System.EventHandler(this.btnRemoveLineFrom_Click);
            // 
            // domainRemove
            // 
            this.domainRemove.Location = new System.Drawing.Point(214, 143);
            this.domainRemove.Name = "domainRemove";
            this.domainRemove.Size = new System.Drawing.Size(135, 24);
            this.domainRemove.TabIndex = 7;
            this.domainRemove.Text = "0";
            // 
            // btnRemoveLastLine
            // 
            this.btnRemoveLastLine.Location = new System.Drawing.Point(27, 174);
            this.btnRemoveLastLine.Name = "btnRemoveLastLine";
            this.btnRemoveLastLine.Size = new System.Drawing.Size(144, 30);
            this.btnRemoveLastLine.TabIndex = 6;
            this.btnRemoveLastLine.Text = "Remove Last Line";
            this.btnRemoveLastLine.UseVisualStyleBackColor = true;
            this.btnRemoveLastLine.Click += new System.EventHandler(this.btnRemoveLastLine_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(27, 226);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(322, 30);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Location = new System.Drawing.Point(18, 9);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(49, 18);
            this.Action.TabIndex = 11;
            this.Action.Text = "Action";
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 521);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listOfLines);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StackForm";
            this.Text = "Text Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfLines;
        private System.Windows.Forms.Button btnAddLineToEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertLine;
        private System.Windows.Forms.TextBox txLine;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveLineFrom;
        private System.Windows.Forms.DomainUpDown domainRemove;
        private System.Windows.Forms.Button btnRemoveLastLine;
        private System.Windows.Forms.Label Action;
    }
}

