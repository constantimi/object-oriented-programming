using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Animal
    {
        // Variables
        protected string name;
        protected int age;

        // Default constructor
        public Animal()
        {

        }

        // Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Animal(string name)
        {
            this.name = name;
            this.age = 1;
            Console.WriteLine($"Animal: {this.name} {this.age}");
        }

        // Constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"Animal: {this.name} {this.age}");
        }

        // Methods
        public virtual void CelebrateBirthday()
        {
            if (this.age <= 100)
                this.age += 1;
        }


        public virtual string ToString()
        {
            return $"{this.name}({this.age})";
        }
    }
}
