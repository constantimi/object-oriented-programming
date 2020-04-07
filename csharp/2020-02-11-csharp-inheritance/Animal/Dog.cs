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
            this.name = name;
            base.ToString();
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
            base.ToString();

        }

        // Methods
        public override void CelebrateBirthday()
        {
            if (this.age <= 20)
            {
                this.age += 1;
            }
        }

        public override string ToString()
        {
            return $"Dog: {this.name}({this.age})";
        }
    }
}
