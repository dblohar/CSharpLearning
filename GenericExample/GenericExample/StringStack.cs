using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    public class StringStack
    {
        private int[] stack;
        public int Position { get; private set; }
        public void Push(string value) { throw new NotImplementedException(); }
        public string Pop() { throw new NotImplementedException(); }
    }
}
