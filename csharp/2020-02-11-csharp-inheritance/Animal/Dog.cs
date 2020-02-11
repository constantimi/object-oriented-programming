using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
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
        }
        public Dog(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;

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
