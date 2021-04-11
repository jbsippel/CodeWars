using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSidesOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Console.ReadLine();
        }

        public static int FindEvenIndex(int[] arr)
        {
            List<int> list = arr.ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list.Take(i).ToList().Sum() == list.Skip(i + 1).ToList().Sum())
                    return i;
            }
            return -1;
        }
    }
}
