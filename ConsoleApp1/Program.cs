using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string numberRangeFormat = @"<\d+,\d+>";

        static void Main(string[] args)
        {
            var strs = new YieldTest().GetStrings2();
            foreach (var str in strs)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
