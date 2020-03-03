namespace Airline
{
    partial class Form1
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
            this.listAirPlaneDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.textEconomy = new System.Windows.Forms.TextBox();
            this.textBusiness = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bthCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboIdPlane = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSenior = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboRoles = new System.Windows.Forms.ComboBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listPassengers = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelAirplane = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAirPlaneDetails
            // 
            this.listAirPlaneDetails.FormattingEnabled = true;
            this.listAirPlaneDetails.ItemHeight = 18;
            this.listAirPlaneDetails.Location = new System.Drawing.Point(534, 22);
            this.listAirPlaneDetails.Name = "listAirPlaneDetails";
            this.listAirPlaneDetails.Size = new System.Drawing.Size(433, 130);
            this.listAirPlaneDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Airplane Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of AirPlane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Economy Class Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Business Class Seats";
            // 
            // comboTypes
            // 
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.Items.AddRange(new object[] {
            "Airbus A300",
            "Airbus A310",
            "Airbus A330",
            "Airbus A340",
            "Airbus A350",
            "Airbus A380",
            "Boeing 747",
            "Boeing 767",
            "Boeing 777",
            "Boeing 787",
            "Lockheed L-1011 TriStar",
            "McDonnell Douglas DC-10",
            "McDonnell Douglas MD-11",
            "Ilyushin Il-86",
            "Ilyushin Il-96"});
            this.comboTypes.Location = new System.Drawing.Point(239, 63);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(193, 26);
            this.comboTypes.TabIndex = 5;
            // 
            // textEconomy
            // 
            this.textEconomy.Location = new System.Drawing.Point(239, 130);
            this.textEconomy.Name = "textEconomy";
            this.textEconomy.Size = new System.Drawing.Size(100, 24);
            this.textEconomy.TabIndex = 6;
            // 
            // textBusiness
            // 
            this.textBusiness.Location = new System.Drawing.Point(239, 186);
            this.textBusiness.Name = "textBusiness";
            this.textBusiness.Size = new System.Drawing.Size(100, 24);
            this.textBusiness.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bthCreate);
            this.panel1.Controls.Add(this.comboTypes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBusiness);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textEconomy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 278);
            this.panel1.TabIndex = 8;
            // 
            // bthCreate
            // 
            this.bthCreate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bthCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthCreate.Location = new System.Drawing.Point(323, 229);
            this.bthCreate.Name = "bthCreate";
            this.bthCreate.Size = new System.Drawing.Size(141, 34);
            this.bthCreate.TabIndex = 8;
            this.bthCreate.Text = "Create";
            this.bthCreate.UseVisualStyleBackColor = false;
            this.bthCreate.Click += new System.EventHandler(this.bthCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboIdPlane);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkSenior);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.comboRoles);
            this.panel2.Controls.Add(this.textAge);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(22, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 284);
            this.panel2.TabIndex = 9;
            // 
            // comboIdPlane
            // 
            this.comboIdPlane.FormattingEnabled = true;
            this.comboIdPlane.Location = new System.Drawing.Point(146, 11);
            this.comboIdPlane.Name = "comboIdPlane";
            this.comboIdPlane.Size = new System.Drawing.Size(193, 26);
            this.comboIdPlane.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Plane";
            // 
            // checkSenior
            // 
            this.checkSenior.AutoSize = true;
            this.checkSenior.Location = new System.Drawing.Point(184, 244);
            this.checkSenior.Name = "checkSenior";
            this.checkSenior.Size = new System.Drawing.Size(18, 17);
            this.checkSenior.TabIndex = 11;
            this.checkSenior.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "*are you senior";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(323, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboRoles
            // 
            this.comboRoles.FormattingEnabled = true;
            this.comboRoles.Items.AddRange(new object[] {
            "Pilot",
            "Attendant",
            "Passenger"});
            this.comboRoles.Location = new System.Drawing.Point(146, 63);
            this.comboRoles.Name = "comboRoles";
            this.comboRoles.Size = new System.Drawing.Size(193, 26);
            this.comboRoles.TabIndex = 5;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(146, 183);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(193, 24);
            this.textAge.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Role";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(146, 124);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(193, 24);
            this.textName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Age";
            // 
            // listPassengers
            // 
            this.listPassengers.FormattingEnabled = true;
            this.listPassengers.ItemHeight = 18;
            this.listPassengers.Location = new System.Drawing.Point(534, 206);
            this.listPassengers.Name = "listPassengers";
            this.listPassengers.Size = new System.Drawing.Size(433, 346);
            this.listPassengers.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(534, 563);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelAirplane
            // 
            this.labelAirplane.AutoSize = true;
            this.labelAirplane.Location = new System.Drawing.Point(534, 183);
            this.labelAirplane.Name = "labelAirplane";
            this.labelAirplane.Size = new System.Drawing.Size(0, 18);
            this.labelAirplane.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 645);
            this.Controls.Add(this.labelAirplane);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listPassengers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listAirPlaneDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Airplane";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAirPlaneDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.TextBox textEconomy;
        private System.Windows.Forms.TextBox textBusiness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bthCreate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkSenior;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboIdPlane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listPassengers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelAirplane;
        private System.Windows.Forms.Timer timer;
    }
}

