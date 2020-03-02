using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Attendant : Role
    {
        // Variables 
        private bool senior;

        // Default constructor
        public Attendant()
        {

        }

        // Constructor
        public Attendant(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Senior = false;
        }

        public Attendant(string name, int age, bool senior) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Senior = senior;
        }

        // Getters and Setters
        public bool Senior { get => senior; set => senior = value; }

        //Methods

        /// <summary>
        /// By default bool variable is always False
        /// </summary>
        /// <returns> boolean True/False</returns>
        public override bool IsSenior()
        {
            return this.Senior;
        }

        // Abstract method
        /// <summary>
        /// Get all details for the Attendant
        /// </summary>
        /// <returns> Information </returns>
        public override string GetInfo()
        {
            return this.Senior ? $"Senior attendant {this.Name}, age: {this.Age}" : $"Attendant {this.Name}, age: {this.Age}";
        }
    }
}
