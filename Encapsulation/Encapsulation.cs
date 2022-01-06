using System;
namespace ProgrammingConcepts.oo
{
    public class Encapsulation
    {
        private int minimum;
        private int total = 0;

        public Encapsulation(int initialMinimum)
        {
            this.minimum = initialMinimum;
        }

        public bool isEnough()
        {
            return this.total > this.minimum;
        }

        public void add(int value)
        {
            this.total += value;
        }
    }

    class EncapsulationExample
    {
        static void teste()
        {
            Encapsulation example = new Encapsulation(100);
            Console.WriteLine(example.isEnough());
            example.add(200);
            Console.WriteLine(example.isEnough());
            // example.teste; // it's not going to compile
        }
    }
}
