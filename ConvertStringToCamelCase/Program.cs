using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));
            Console.ReadLine();
        }

        public static string ToCamelCase(string str)
        {
            string[] words = str.Split(new char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Count() == 0)
                return "";
            str = words[0];
            foreach (var word in words.Skip(1))
                str += Char.ToUpper(word[0]) + word.Substring(1).ToLower();

            return str;
        }
    }
}
