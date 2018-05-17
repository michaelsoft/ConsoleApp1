using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class YieldTest
    {
        public IEnumerable<string> GetStrings1()
        {
            return new string[]{ "a","b","c"};
        }

        public IEnumerable<string> GetStrings2()
        {
            yield return "a";
        }
    }
}
