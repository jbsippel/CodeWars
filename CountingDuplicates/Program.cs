using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aabbcde"));
            Console.WriteLine(DuplicateCount("Indivisibility"));
            Console.ReadLine();
        }

        public static int DuplicateCount(string str)
        {
            var chars = str.ToUpper().ToCharArray();
            return chars.GroupBy(c => c).Where(c => c.Count() > 1).Count();
        }
    }
}
