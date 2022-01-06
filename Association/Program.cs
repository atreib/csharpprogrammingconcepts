using System;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andre = new Person("Andre");
            Person giovana = new Person("Giovana");
            Person kid = new Person("Joseph");

            andre.Marry(giovana);
            giovana.Marry(andre);

            Console.WriteLine(String.Format("Andre is married with {0}.", andre.IsMarriedTo()));
            Console.WriteLine(String.Format("Giovana is married to {0}.", giovana.IsMarriedTo()));
            Console.WriteLine(String.Format("Joseph, which is a kid, is married with no one, so it returns: {0}.", kid.IsMarriedTo()));
        }
    }
}
