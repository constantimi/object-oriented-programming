using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Pilot : Role
    {
        // Variables 
        private bool senior;

        // Default constructor
        public Pilot()
        {

        }

        // Constructor
        public Pilot(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Senior = false;
        }

        public Pilot(string name, int age, bool senior) : base(name, age)
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
        /// Get all details for the Pilot
        /// </summary>
        /// <returns> Information </returns>
        public override string GetInfo()
        {
            return this.Senior ? $"Senior pilot {this.Name}, age: {this.Age}": $"Pilot {this.Name}, age: {this.Age}";
        }
    }
}
