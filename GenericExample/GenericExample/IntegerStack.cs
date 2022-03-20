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

    public class StringStack
    {
        public StringStack()
        {
            this.Position = 0;
        }
        private string[] stack = new string[100];

        public int Position { get; private set; }
        public void Push(string value) { stack[Position++] = value; }
        public string Pop() { return stack[--Position]; }
    }

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


    internal class Person
    {
        public Person()
        {
        }
    }

}
