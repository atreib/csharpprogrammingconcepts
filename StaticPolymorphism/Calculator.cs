using System;
namespace StaticPolymorphism
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int[] numbers)
        {
            // From .NET 3.5 forward, we can: numbers.Sum()
            // But since we're working with 3.1, so:
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}
