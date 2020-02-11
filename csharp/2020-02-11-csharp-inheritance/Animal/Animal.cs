using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
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
        public Animal(string name){
            this.name = name;
            this.age = 1;
        }

        // Constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Methods
        public virtual void CelebrateBirthday()
        {
            if(this.age <= 100)
                this.age += 1;
        }

        
        public virtual string ToString()
        {
            return $"{this.name}({this.age})";
        }


    }
}
