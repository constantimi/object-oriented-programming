using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public abstract class Role
    {
        // Variables
        private string name;
        private int age;
        
        // Default constructor
        public Role()
        {

        }

        // Constructor
        public Role(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        // Methods
        public virtual bool IsSenior()
        {
            return false;
        }

        // Abstract method
        public abstract string GetInfo();

    }
}
