using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRangeOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GenerateRange(2, 10, 2))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> range = new List<int>();
            for (int i = min; i <= max; i += step)
                range.Add(i);
            return range.ToArray();
        }
    }
}
