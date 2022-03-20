using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class StringStack2
    {
        public StringStack2()
        {
            this.Position = 0;  
        }
        private string[] stack = new string[100];

        public int Position { get; private set; }
        public void Push(string value) {  stack[Position++] = value; }
        public string Pop() { return stack[--Position];  }
    }
}
