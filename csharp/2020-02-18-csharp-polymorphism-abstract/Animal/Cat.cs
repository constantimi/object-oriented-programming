using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Cat : Animal
    {
        // Default constructor
        public Cat()
        {

        }

        //Constructor

        public Cat(string name) : base(name)
        {
            this.Name = name;
            base.ToString();
        }
        public Cat(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            base.ToString();

        }

        // Methods
        public override void CelebrateBirthday()
        {
            if (this.Age <= 25)
            {
                this.Age += 1;
            }
        }

        public override string ToString()
        {
            return $"Cat: {this.Name}, age: {this.Age}";
        }

        // Abstract method
        public override string Speak(string speach)
        {
            return $"Cat: {speach}";
        }
    }
}
