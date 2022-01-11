using System;
namespace DynamicPolymorphism
{
    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Woof";
        }
    }
}
