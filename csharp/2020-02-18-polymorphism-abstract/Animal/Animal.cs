using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public abstract class Animal
    {
        // Variables
        private string name;
        private int age;

       

        // Default constructor
        public Animal()
        {

        }

        // Getter and Setters
        protected string Name { get => name; set => name = value; }
        protected int Age { get => age; set => age = value; }

        // Constructor
        public Animal(string name)
        {
            this.Name = name;
            this.Age = 1;
            Console.WriteLine($"Animal: {this.Name}, age: {this.Age}");
        }

        // Constructor
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine($"Animal: {this.Name}, age: {this.Age}");
        }

        // Methods
        public virtual void CelebrateBirthday()
        {
            if (this.Age <= 100)
                this.Age += 1;
        }


        public virtual string ToString()
        {
            return $"{this.Name}, age: {this.Age}";
        }

        // Abstract method
        public abstract string Speak(string speach);

    }
}
