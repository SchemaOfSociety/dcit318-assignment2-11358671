using System;

namespace InheritanceDemo
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class - Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class - Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class
            Animal genericAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call MakeSound() on each instance
            Console.WriteLine("Animal says:");
            genericAnimal.MakeSound();

            Console.WriteLine("Dog says:");
            myDog.MakeSound();

            Console.WriteLine("Cat says:");
            myCat.MakeSound();

            // Pause to keep console window open
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}

