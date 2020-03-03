using Program;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("Bao"));
            animals.Add(new Cat("Miao"));
            animals.Add(new Duck("Duck", 2));

            foreach (Animal a in animals)
            {
                if(a is Cat)
                {
                    a.CelebrateBirthday();
                    Console.WriteLine(a.Speak("I am cat"));
                }
                else if (a is Dog)
                {
                    Console.WriteLine(a.Speak("I am dog"));
                }
                else if (a is Duck)
                {
                    Console.WriteLine(a.Speak("I am duck"));
                }
            }
        }
    }
}
