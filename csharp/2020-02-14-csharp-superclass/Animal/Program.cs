using Program;
using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bao");
            Console.WriteLine(dog.ToString());
            dog.CelebrateBirthday();
            Console.WriteLine(dog.ToString());

            Cat cat = new Cat("Miao", 23);
            Console.WriteLine(cat.ToString());
            cat.CelebrateBirthday();
            Console.WriteLine(cat.ToString());

            Turtle turtle = new Turtle("Turlo", 2);
            Console.WriteLine(turtle.ToString());
            turtle.CelebrateBirthday();
            Console.WriteLine(turtle.ToString());
        }
    }
}
