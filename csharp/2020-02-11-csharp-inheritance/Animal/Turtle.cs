using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Turtle : Animal
    {
        // Default constructor
        public Turtle()
        {

        }

        //Constructor

        public Turtle(string name) : base(name)
        {
            this.name = name;
        }
        public Turtle(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;

        }

        // Methods

        public override string ToString()
        {
            return $"Turtle: {this.name}({this.age})";
        }
    }
}
