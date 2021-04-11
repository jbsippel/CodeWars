using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parentheses
{
    public class Parentheses
    {
        static void Main(string[] args)
        {
            if(ValidParentheses("((())())"))
                Console.WriteLine("Valid!!");
            else
                Console.WriteLine("Invalid!!");

            if (ValidParentheses("()()()()()("))
                Console.WriteLine("Valid!!");
            else
                Console.WriteLine("Invalid!!");

            if (ValidParentheses(")(((()))"))
                Console.WriteLine("Valid!!");
            else
                Console.WriteLine("Invalid!!");

            Console.ReadLine();
        }

        public static bool ValidParentheses(string input)
        {
            if (input.Length > 100)
                return false;

            int count = 0;
            foreach (var item in input)
            {
                if (item == '(')
                    count++;
                if (item == ')')
                    count--;
                if (count < 0)
                    return false;
            }

            if (count == 0)
                return true;
            else
                return false;
        }

    }
}
