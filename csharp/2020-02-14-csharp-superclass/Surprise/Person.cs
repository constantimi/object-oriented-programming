using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Surprise
{
    class Person
    {
        // Instance variables
        protected int age;
        protected int pcn;
        protected string name;
        protected int yearsAtSchool;


        // Additional variables
        private static int pcnSeeder = 10000;

        // Getters and Setters
        public int Age { get => age; set => age = value; }
        public int Pcn { get => pcn; set => pcn = value; }
        public string Name { get => name; set => name = value; }
        public int YearsAtSchool { get => yearsAtSchool; set => yearsAtSchool = value; }

        // Constructor
        public Person()
        {

        }

        public Person(string name, int age, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.pcn = pcn;
            this.name = name;
            this.yearsAtSchool = yearsAtSchool;
        }

        // Methods
        public virtual string ToString()
        {
            return $"{this.name}, age: {this.age}, years at school: {this.yearsAtSchool}, pcn: #{this.pcn}";
        }

        public void ClevreateBirthday()
        {
            this.age += 1;
        }

        public virtual void StartAnotherSchoolyear()
        {
            this.yearsAtSchool += 1;
        }
    }
}
