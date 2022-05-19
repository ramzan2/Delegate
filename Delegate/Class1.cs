using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            string testString = "LAMP";

            Console.WriteLine("Общее количество символов: {0}", TestDelegate(d1, testString));
            Console.WriteLine("Количество символов A: {0}", TestDelegate(d2, testString));

            Console.ReadLine();
        }

        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }
}
