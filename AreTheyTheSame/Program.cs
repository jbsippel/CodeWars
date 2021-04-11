using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(comp(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 },new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 }));
            Console.ReadLine();
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;
            if (a.Length == 0 && b.Length == 0)
                return true;
            if (a.Length == 0 || b.Length == 0)
                return false;

            a = a.OrderBy(c => c).ToArray();
            b = b.OrderBy(c => c).ToArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (b[i] != a[i] * a[i])
                    return false;
            }

            return true;
        }
    }
}
