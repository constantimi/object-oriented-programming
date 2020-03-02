using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Teacher : Person
    {
        // Variables
        private JobPosition JobPosition;
        private double salary;

        // Constructor
        public Teacher()
        {

        }

        public Teacher(string name, int age, int pcn, int yearsAtSchool, double salary) : base(name, age, pcn, yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
            this.salary = salary;
            this.JobPosition = JobPosition.JUNIOR_TEACHER;

        }

        // Getters and Setters
        public double Salary { get => salary; set => salary = value; }

        // Override Abstract methods
        public override string ToString()
        {
            return $"{this.name}, age: {this.age}, years at school: {this.yearsAtSchool}, pcn: #{this.pcn}, salary {this.salary}:";
        }
        public override void CelabrateBirthday()
        {
            base.age += 1;
        }

        // Inheritated methods
        public override void StartAnotherSchoolyear()
        {
            base.yearsAtSchool += 1;
            if (base.yearsAtSchool % 3 == 0)
            {
                this.salary += (this.salary * 0.1);
            }
        }

        public override void MakePromotion()
        {
            if (this.JobPosition == JobPosition.JUNIOR_TEACHER)
            {
                this.JobPosition = JobPosition.TEACHER1;
            }
            else if (this.JobPosition == JobPosition.TEACHER1)
            {
                this.JobPosition = JobPosition.TEACHER2;
            }
            else if (this.JobPosition == JobPosition.TEACHER2)
            {
                this.JobPosition = JobPosition.TEACHER3;
            }
            else if (this.JobPosition == JobPosition.TEACHER3)
            {
                this.JobPosition = JobPosition.COORDINATOR;
            }
            else if (this.JobPosition == JobPosition.COORDINATOR)
            {
                this.JobPosition = JobPosition.DIRECTOR;
            }

            this.JobPosition = JobPosition.DIRECTOR;

        }
    }
}
