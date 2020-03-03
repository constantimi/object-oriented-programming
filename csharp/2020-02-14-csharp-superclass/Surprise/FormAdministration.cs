using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surprise
{
    public partial class FormAdministration : Form
    {
        // Variables
        private Administration administration;
        private int pcn;

        // Additional Variables
        private static int seeder = 1000;

        // Getters and Setters
        internal Administration Administration { get => administration; set => administration = value; }
        public int Pcn { get => pcn; set => pcn = value; }

        // Constructor
        public FormAdministration()
        {
            InitializeComponent();
            this.administration = new Administration();
            this.textPCN.Text = seeder.ToString();
            this.pcn = seeder;
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(this.textAge.Text);
                string name = this.textName.Text;
                this.textPCN.Text = seeder.ToString();
                int pcn = seeder;
                seeder++;
                int years = Convert.ToInt32(this.textYear.Text);

                Person person = new Person(name, age, pcn, years);

                if (this.administration.GetTeacher(pcn) == null && this.administration.GetStudent(pcn) == null && this.administration.GetPerson(pcn) == null)
                {
                    this.administration.AddPerson(person);
                    MessageBox.Show("Created new person!");
                }
                else
                {
                    MessageBox.Show("Already exists");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Add correct values, please!");
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(this.textAge.Text);
                string name = this.textName.Text;
                this.textPCN.Text = seeder.ToString();
                int pcn = seeder;
                seeder++;
                int years = Convert.ToInt32(this.textYear.Text);
                int ec = Convert.ToInt32(this.textECs.Text);

                Student student = new Student(name, age, pcn, years, ec);
                if (this.administration.GetTeacher(pcn) == null && this.administration.GetStudent(pcn) == null && this.administration.GetPerson(pcn) == null)
                {
                    this.administration.AddStudent(student);
                    MessageBox.Show("Created new person!");
                }
                else
                {
                    MessageBox.Show("Already exists");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Add correct values, please!");
            }
}

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(this.textAge.Text);
                string name = this.textName.Text;
                this.textPCN.Text = seeder.ToString();
                int pcn = seeder;
                seeder++;
                int years = Convert.ToInt32(this.textYear.Text);
                double salary = Convert.ToDouble(this.textSalary.Text);

                Teacher teacher = new Teacher(name, age, pcn, years, salary);

                if (this.administration.GetTeacher(pcn) == null && this.administration.GetStudent(pcn) == null && this.administration.GetPerson(pcn) == null)
                {
                    this.administration.AddTeacher(teacher);
                    MessageBox.Show("Created new person!");
                }
                else
                {
                    MessageBox.Show("Already exists");
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Add correct values, please!");
            }
        }

        private void btnAllPerson_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            foreach (Person p in administration.GetPersons())
            {
                this.listResult.Items.Add(p.ToString());
            }
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            foreach (Student s in administration.GetStudents())
            {
                this.listResult.Items.Add(s.ToString());
            }
        }

        private void btnAllTeachers_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            foreach (Teacher t in administration.GetTeachers())
            {
                this.listResult.Items.Add(t.ToString());
            }
        }

        // Person
        private void button1_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            if (this.administration.GetPerson(pcn) != null)
            {
                this.listResult.Items.Add(this.administration.GetPerson(pcn).ToString());
            }
            else
            {
                MessageBox.Show("Doesn't exist");
            }
        }

        // Student
        private void button4_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            if (this.administration.GetStudent(pcn) != null)
            {
                this.listResult.Items.Add(this.administration.GetStudent(pcn).ToString());
            }
            else
            {
                MessageBox.Show("Doesn't exist");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.administration.GetStudent(pcn).StartAnotherSchoolyear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.administration.GetStudent(pcn).AddECs(Convert.ToInt32(this.textBoxEC.Text));
        }

        // Teacher
        private void button5_Click(object sender, EventArgs e)
        {
            this.listResult.Items.Clear();

            if (this.administration.GetTeacher(pcn) != null)
            {
                this.listResult.Items.Add(this.administration.GetTeacher(pcn).ToString());
            }
            else
            {
                MessageBox.Show("Doesn't exist");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.administration.GetTeacher(pcn).StartAnotherSchoolyear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.administration.GetTeacher(pcn).MakePromotion();
        }
    }
}
