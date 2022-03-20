using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class ObjectStack
    {
        public ObjectStack()
        {
            this.Position = 0;
        }
        private object[] stack = new object[100];

        public int Position { get; private set; }
        public void Push(object value) { stack[Position++] = value; }
        public object Pop() { return stack[--Position]; }
    }
}
