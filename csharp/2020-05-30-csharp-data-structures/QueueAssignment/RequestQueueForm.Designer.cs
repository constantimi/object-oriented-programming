namespace QueueAssignment
{
    partial class RequestQueueForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txTicketId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetNextTicket = new System.Windows.Forms.Button();
            this.txName = new System.Windows.Forms.TextBox();
            this.btnHandleIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "TicketId :";
            // 
            // txTicketId
            // 
            this.txTicketId.Location = new System.Drawing.Point(201, 254);
            this.txTicketId.Name = "txTicketId";
            this.txTicketId.Size = new System.Drawing.Size(129, 22);
            this.txTicketId.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description :";
            // 
            // txDescription
            // 
            this.txDescription.Location = new System.Drawing.Point(201, 208);
            this.txDescription.Name = "txDescription";
            this.txDescription.Size = new System.Drawing.Size(301, 22);
            this.txDescription.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email :";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(201, 159);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(204, 22);
            this.txEmail.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // btnGetNextTicket
            // 
            this.btnGetNextTicket.Location = new System.Drawing.Point(76, 25);
            this.btnGetNextTicket.Name = "btnGetNextTicket";
            this.btnGetNextTicket.Size = new System.Drawing.Size(226, 52);
            this.btnGetNextTicket.TabIndex = 10;
            this.btnGetNextTicket.Text = "Get the Next Ticket";
            this.btnGetNextTicket.UseVisualStyleBackColor = true;
            this.btnGetNextTicket.Click += new System.EventHandler(this.btnGetNextTicket_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(201, 110);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(204, 22);
            this.txName.TabIndex = 9;
            // 
            // btnHandleIt
            // 
            this.btnHandleIt.Location = new System.Drawing.Point(358, 25);
            this.btnHandleIt.Name = "btnHandleIt";
            this.btnHandleIt.Size = new System.Drawing.Size(144, 52);
            this.btnHandleIt.TabIndex = 18;
            this.btnHandleIt.Text = "Handled";
            this.btnHandleIt.UseVisualStyleBackColor = true;
            this.btnHandleIt.Click += new System.EventHandler(this.btnHandleIt_Click);
            // 
            // RequestQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 312);
            this.Controls.Add(this.btnHandleIt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txTicketId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetNextTicket);
            this.Controls.Add(this.txName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RequestQueueForm";
            this.Text = "RequestQueueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTicketId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetNextTicket;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Button btnHandleIt;
    }
}