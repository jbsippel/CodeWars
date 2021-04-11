using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses vp = new ValidParentheses();
            while (true)
            {
                string p = Console.ReadLine();
                bool result = vp.isValid(p);
                if (result == true)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
                //Console.ReadLine();
            }
        }
    }
}
