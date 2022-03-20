using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class IntegerStack 
    {
        public IntegerStack()
        {
            Position = 0;   
        }
        private int[] stack = new int[100];
        public int Position { get; private set; }   
        public void Push(int value) { stack[Position++]= value; }
        public int Pop() { return stack[--Position];  }        
    }

}
