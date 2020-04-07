using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Passenger : Role
    {
        // Default constructor
        public Passenger()
        {

        }

        // Constructor
        public Passenger(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }


        // Abstract method
        /// <summary>
        /// Get all details for the Passenger
        /// </summary>
        /// <returns> Information </returns>
        public override string GetInfo()
        {
            return $"Passenger {this.Name}, age: {this.Age}";
        }
    }
}
