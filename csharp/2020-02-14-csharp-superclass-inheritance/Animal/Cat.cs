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
            this.name = name;
            base.ToString();
        }
        public Cat(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
            base.ToString();

        }

        // Methods
        public override void CelebrateBirthday()
        {
            if (this.age <= 25)
            {
                this.age += 1;
            }
        }

        public override string ToString()
        {
            return $"Cat: {this.name}({this.age})";
        }
    }
}
