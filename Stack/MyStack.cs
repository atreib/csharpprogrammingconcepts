using System;
using System.Collections.Generic;

namespace Stack
{
    public class MyStack
    {
        private List<string> stack = new List<string>();

        public void Push (string element)
        {
            stack.Add(element);
        }

        public string Pop ()
        {
            if (this.stack.Count <= 0) throw new Exception("The stack is empty");
            int lastIndex = this.stack.Count - 1;
            string removedElement = this.stack[lastIndex];
            this.stack.RemoveAt(lastIndex);
            return removedElement;
        }

        public bool IsEmpty()
        {
            return this.stack.Count <= 0;
        }

        public string Top ()
        {
            if (this.stack.Count <= 0) throw new Exception("The stack is empty");
            return this.stack[this.stack.Count - 1];
        }
    }
}
