using System;
namespace DynamicPolymorphism
{ 
    public class Cat : Animal
    {
        public override string Speak()
        {
            return "Meow";
        }
    }
}
