using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyQueue queue = new MyQueue();
                queue.Push("first");
                queue.Push("second");
                queue.Push("third");
                String removed = queue.Pop();
                queue.Push("fourth");

                Console.WriteLine("We pushed 4 elements to our queue");
                Console.WriteLine("We removed 1 element from our queue, which was: {0}", removed);
                Console.WriteLine("Is our queue empty? {0}", queue.IsEmpty());
                Console.WriteLine("The next element we're going to have access is the oldest from our queue: {0}", queue.Top());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
