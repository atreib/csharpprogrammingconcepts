using System;
namespace DynamicPolymorphism
{
    public class Duck : Animal
    {
        public override string Speak()
        {
            return "Quack";
        }
    }
}
