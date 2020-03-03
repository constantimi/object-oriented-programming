using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public abstract class Person
    {
        // Instance variables
        protected int age;
        protected int pcn;
        protected string name;
        protected int yearsAtSchool;

        // Getters and Setters
        public int Age { get => age; set => age = value; }
        public int Pcn { get => pcn; set => pcn = value; }
        public string Name { get => name; set => name = value; }
        public int YearsAtSchool { get => yearsAtSchool; set => yearsAtSchool = value; }

        // Default constructor
        public Person()
        {

        }

        // Constructor
        public Person(string name, int age, int pcn, int yearsAtSchool)
        {
            this.age = age;
            this.pcn = pcn;
            this.name = name;
            this.yearsAtSchool = yearsAtSchool;
        }

        // Method

        /// <summary>
        /// Increment the age with one every year;
        /// </summary>       

        public virtual void StartAnotherSchoolyear()
        {
            this.yearsAtSchool += 1;
        }

        public virtual void MakePromotion() { }

        // Abstract Methods

        /// <summary>
        /// Abstract methods which are going to be overriden
        /// </summary>
        public abstract string ToString();
        public abstract void CelabrateBirthday();
    }
}
