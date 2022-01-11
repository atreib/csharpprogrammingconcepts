using System;
using System.Collections.Generic;

namespace Queue
{
    public class MyQueue
    {
        private List<string> queue = new List<string>();

        public void Push(string element)
        {
            this.queue.Add(element);
        }

        public string Pop()
        {
            if (this.queue.Count <= 0) throw new Exception("The queue is empty");
            string removedElement = this.queue[0];
            this.queue.RemoveAt(0);
            return removedElement;
        }

        public bool IsEmpty()
        {
            return this.queue.Count <= 0;
        }

        public string Top()
        {
            if (this.queue.Count <= 0) throw new Exception("The stack is empty");
            return this.queue[0];
        }
    }
}
