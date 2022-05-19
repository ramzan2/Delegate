using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int CountDelegate(string message);
    class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }
        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }
        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }


    }
}
