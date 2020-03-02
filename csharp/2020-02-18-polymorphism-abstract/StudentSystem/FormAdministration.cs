using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class FormAdministration : Form
    {
        // Variables
        private Administration administration;

        // Constructor
        /// <summary>
        /// Initialize all components and variables
        /// </summary>
        public FormAdministration()
        {
            InitializeComponent();
            this.Administration = new Administration();
        }

        // Getters and Setters
        internal Administration Administration { get => administration; set => administration = value; }

        /// <summary>
        /// Add a person to the person collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.radioStudent.Checked)
            {
                try
                {
                    string name = this.textName.Text.ToString();
                    int age = Convert.ToInt32(this.textAge.Text);
                    int years = Convert.ToInt32(this.textYear.Text);
                    int ec = Convert.ToInt32(this.textEC.Text);
                    int pcn = Convert.ToInt32(this.textAddPCN.Text);

                    if (this.Administration.GetPerson(pcn) == null)
                    {
                        Person p1 = new Student(name, age, pcn, years, ec);
                        this.Administration.AddPerson(p1);
                        MessageBox.Show("The student is added!");
                    }
                    else
                    {
                        MessageBox.Show("Please choose unique PCN!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter correct details!");
                }    
            }
            else if (this.radioTeacher.Checked)
            {
                try
                {
                    string name = this.textName.Text.ToString();
                    int age = Convert.ToInt32(this.textAge.Text);
                    int years = Convert.ToInt32(this.textYear.Text);
                    int ec = Convert.ToInt32(this.textEC.Text);
                    int pcn = Convert.ToInt32(this.textAddPCN.Text);
                    double salary = Convert.ToDouble(this.textSalary.Text);
                    if (this.Administration.GetPerson(pcn) == null)
                    {
                        Person p2 = new Teacher(name, age, pcn, years, salary);
                        this.Administration.AddPerson(p2);
                        MessageBox.Show("The teacher is added!");
                    }
                    else
                    {
                        MessageBox.Show("Please choose unique PCN!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter correct details!");
                }
            }
            
            
        }

        /// <summary>
        /// Show information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
            this.listResult.Items.Clear();

            if(this.comboShowPerson.SelectedIndex > -1)
            {
                switch (this.comboShowPerson.SelectedItem.ToString())
                {
                    case "All":
                        foreach (Person p in this.Administration.GetPersons())
                        {
                            this.listResult.Items.Add(p.ToString());
                        }
                        break;

                    case "Students":
                        foreach (Person p in this.Administration.GetPersons())
                        {
                            if (p is Student)
                            {
                                this.listResult.Items.Add(p.ToString());
                            }
                        }
                        break;

                    case "Teachers":
                        foreach (Person p in this.Administration.GetPersons())
                        {
                            if (p is Teacher)
                            {
                                this.listResult.Items.Add(p.ToString());
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Timer update the information in the ResultList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.radioStudent.Checked)
            {
                // Activate options
                this.textSalary.Enabled = false;
                this.textEC.Enabled = true;
            }
            else if (this.radioTeacher.Checked)
            {
                // Activate options
                this.textSalary.Enabled = true;
                this.textEC.Enabled = false;
            }
            else
            {
                // Activate options
                this.textSalary.Enabled = false;
                this.textEC.Enabled = false;
            }
        }

        /// <summary>
        /// Search by PartialNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            try
            {
                int parPcn = Convert.ToInt32(this.textPartialNumber.Text);

                List<Person> listPerson = this.Administration.GetPersonsByParialPCN(parPcn);

                foreach(Person p in listPerson)
                {
                    this.listResult.Items.Add(p.ToString());
                }
               

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }

        private void ShowInfo(Person person)
        {
            this.listResult.Items.Clear();
               
            if (person != null)
            {
                this.listResult.Items.Add(person.ToString());
            }
            else
            {
                this.listResult.Items.Add("There is no one with this name!");
            }
      
        }

        /// <summary>
        /// Show information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int pcnAction = Convert.ToInt32(this.textActionPCN.Text);

                Person person = this.Administration.GetPerson(pcnAction);
                ShowInfo(person);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }

        private void btnCelebrateBirth_Click(object sender, EventArgs e)
        {
            try
            {
                int pcnAction = Convert.ToInt32(this.textActionPCN.Text);

                Person person = this.Administration.GetPerson(pcnAction);
                person.CelabrateBirthday();
                ShowInfo(person);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }

        private void btnStartNewYear_Click(object sender, EventArgs e)
        {
            try
            {               

                int pcnAction = Convert.ToInt32(this.textActionPCN.Text);

                Person person = this.Administration.GetPerson(pcnAction);
                if (person is Teacher)
                {
                    person.StartAnotherSchoolyear();
                    ShowInfo(person);
                }
                else
                {
                    MessageBox.Show("Sorry, but it is a student!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            try
            {
                int pcnAction = Convert.ToInt32(this.textActionPCN.Text);

                Person person = this.Administration.GetPerson(pcnAction);
                if (person is Teacher)
                {
                    person.MakePromotion();
                    ShowInfo(person);
                }
                else
                {
                    MessageBox.Show("Sorry, but it is a student!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }

        private void btnEC_Click(object sender, EventArgs e)
        {
            try
            {
                int pcnAction = Convert.ToInt32(this.textActionPCN.Text);

                Person person = this.Administration.GetPerson(pcnAction);
                if (person is Student)
                {
                    ((Student)person).NrOfECs = Convert.ToInt32(this.textActionEC.Text);
                    ShowInfo(person);
                }
                else
                {
                    MessageBox.Show("Sorry, but it is a teacher");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter correct data!");
            }
        }
    }
}
