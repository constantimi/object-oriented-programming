using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Student : Person
    {
        // Variables
        private int nrOfECs;

        // Constructor
        public Student()
        {

        }
        public Student(string name, int age, int pcn, int yearsAtSchool, int nrOfECs) : base(name, age, pcn, yearsAtSchool)
        {
            this.age = age;
            this.name = name;
            this.pcn = pcn;
            this.yearsAtSchool = yearsAtSchool;
            this.nrOfECs = nrOfECs;
        }

        // Getters and Setters
        public int NrOfECs { get => nrOfECs; set => nrOfECs = value; }

        // Override Abstract Methods
        public override string ToString()
        {
            return $"{this.name}, age: {this.age}, years at school: {this.yearsAtSchool}, pcn: #{this.pcn}, EC's: {this.nrOfECs}";
        }

        public override void CelabrateBirthday()
        {
            base.age += 1;
        }

        // Add EC
        public void AddECs(int n)
        {
            this.nrOfECs += n;
        }

    }
}
