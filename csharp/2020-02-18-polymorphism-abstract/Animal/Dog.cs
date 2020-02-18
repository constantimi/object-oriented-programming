using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Dog : Animal
    {
        // Default constructor
        public Dog()
        {

        }

        //Constructor

        public Dog(string name) : base(name)
        {
            this.Name = name;
            base.ToString();
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
            base.ToString();

        }

        // Methods
        public override void CelebrateBirthday()
        {
            if (this.Age <= 20)
            {
                this.Age += 1;
            }
        }

        public override string ToString()
        {
            return $"Dog: {this.Name}, age: {this.Age}";
        }

        // Abstract method
        public override string Speak(string speach)
        {
            return $"Dog: {speach}";
        }
    }
}
