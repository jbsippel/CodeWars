using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaditCardMask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("4556364607935616"));
            Console.ReadLine();
        }

        public static string Maskify(string cc)
        {
            int toMask = cc.Count() - 4 < 0 ? 0 : cc.Count() - 4;
            return new String('#', toMask) + cc.Substring(toMask);
        }
    }
}
