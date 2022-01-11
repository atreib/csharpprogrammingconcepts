using System;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal parentAnimal = new Animal(); // Animal reference and object
            Animal dog = new Dog(); // Animal reference, Dog object
            Animal duck = new Duck(); // Animal reference, Duck object
            Cat cat = new Cat(); // Cat reference and object

            Console.WriteLine("An animal says: {0}", parentAnimal.Speak()); // Output: "aaaaa"
            Console.WriteLine("A dog says: {0}", dog.Speak()); // Output: "Woof"
            Console.WriteLine("A duck says: {0}", duck.Speak()); // Output: "Quack"
            Console.WriteLine("A cat says: {0}", cat.Speak()); // Output: "Meow"
        }
    }
}
