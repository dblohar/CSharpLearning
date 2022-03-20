using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    internal class Languages
    {
        string[] languages = new string[100];

        public string this[int index] {

            get { return languages[index]; }
       
            set { languages[index] = value; }
        }
    }
}
