using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringToNumber("10"));
            Console.ReadLine();
        }

        public static int StringToNumber(String str)
        {
            Int32.TryParse(str, out int result);
            return result;
        }
    }
}
