using System;
using ProgrammingConcepts.oo;

namespace ProgrammingConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation example = new Encapsulation(100);
            Console.WriteLine(example.isEnough());
            example.add(200);
            Console.WriteLine(example.isEnough());
            // example.teste; // it's not going to compile
        }
    }
}
