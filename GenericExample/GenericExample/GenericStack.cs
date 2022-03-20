using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class GenericStack<T>
    {
        public GenericStack()
        {
            Position = 0;
        }
        private T[] stack = new T[100];
        public int Position { get; private set; }
        public void Push(T value) { stack[Position++] = value; }
        public T Pop() { return stack[--Position]; }
    }

}
