using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Duck : Animal
    {
        // Default constructor
        public Duck()
        {

        }

        //Constructor

        public Duck(string name) : base(name)
        {
            this.Name = name;
            base.ToString();
        }
        public Duck(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            base.ToString();

        }

        // Methods
        public override string ToString()
        {
            return $"Duck: {this.Name}, age: {this.Age}";
        }

        // Abstract method
        public override string Speak(string speach)
        {
            return $"Duck: {speach}";
        }
    }
}
