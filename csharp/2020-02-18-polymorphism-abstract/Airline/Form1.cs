using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Form1 : Form
    {
        // Variables
        private List<Airplane> airplanes;
        private int seeder;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            this.airplanes = new List<Airplane>();
            this.seeder = 1;
        }
        private void bthCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables 
                string type = this.comboTypes.SelectedItem.ToString();
                int economy = Convert.ToInt32(this.textEconomy.Text);
                int business = Convert.ToInt32(this.textBusiness.Text);
                Airplane air = new Airplane(seeder, type, business, economy);
                this.seeder++;

                // Add to the list
                this.airplanes.Add(air);
                this.comboIdPlane.Items.Add(air.Id);
                
                // Show message
                MessageBox.Show("Created!");

            }
            catch (Exception)
            {
                MessageBox.Show("Add correct values!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(Airplane a in this.airplanes)
            {
                if(this.comboIdPlane.SelectedIndex > -1 && this.comboIdPlane.SelectedItem.ToString().Equals(a.Id))
                {
                    if (this.comboRoles.SelectedIndex > -1) {
                        switch (this.comboRoles.SelectedItem.ToString())
                        {
                            case "Pilot":
                                Pilot pt = this.checkSenior.Checked ? new Pilot(this.textName.Text.ToString(), Convert.ToInt32(this.textAge.Text), true) : new Pilot(this.textName.Text.ToString(), Convert.ToInt32(this.textAge.Text));
                                if (a.AddInAirplane(pt))
                                {
                                    MessageBox.Show("Added!");
                                }
                                else
                                {
                                    MessageBox.Show("Can't add more!");
                                }
                                break;
                            case "Attendant":
                                Attendant at = this.checkSenior.Checked ? new Attendant(this.textName.Text.ToString(), Convert.ToInt32(this.textAge.Text), true) : new Attendant(this.textName.Text.ToString(), Convert.ToInt32(this.textAge.Text));
                                if (a.AddInAirplane(at))
                                {
                                    MessageBox.Show("Added!");
                                }
                                else
                                {
                                    MessageBox.Show("Can't add more!");
                                }
                                break;
                            case "Passenger":
                                Passenger ps = new Passenger(this.textName.Text.ToString(), Convert.ToInt32(this.textAge.Text));
                                if (a.AddInAirplane(ps))
                                {
                                    MessageBox.Show("Added!");
                                }
                                else
                                {
                                    MessageBox.Show("Can't add more!");
                                }
                                break;
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Select Role!");
                    }


                }
                else
                {
                    MessageBox.Show("Select Airplain Id!");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // first list box
            this.listAirPlaneDetails.Items.Clear();
            
            foreach (Airplane a in this.airplanes)
            {
                this.listAirPlaneDetails.Items.Add("#" + a.Id.ToString() + " " + a.TypeAirplane.ToString());
            }

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.listPassengers.Items.Clear();

            if (this.listAirPlaneDetails.SelectedIndex > -1)
            {
                foreach (Airplane a in this.airplanes)
                {
                    if (a.Id.Equals(this.listAirPlaneDetails.SelectedItem.ToString().Substring(1, 4)))
                    {
                        foreach (Role r in a.Roles)
                        {
                            this.listPassengers.Items.Add(r.GetInfo());
                        }

                        this.labelAirplane.Text = "Can the airplane take off:" + Convert.ToString(a.CanAirplaneTakeOff());
                    }
                }
            }
        }
    }
}
