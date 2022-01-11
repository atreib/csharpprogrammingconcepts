using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyStack stack = new MyStack();
                stack.Push("first");
                stack.Push("second");
                stack.Push("third");
                String removed = stack.Pop();
                stack.Push("fourth");

                Console.WriteLine("We pushed 4 elements to our stack");
                Console.WriteLine("We removed 1 element from our stack, which was: {0}", removed);
                Console.WriteLine("Is our stack empty? {0}", stack.IsEmpty());
                Console.WriteLine("The next element we're going to have access is the last we added to our stack: {0}", stack.Top());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
