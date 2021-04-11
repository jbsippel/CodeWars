using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class ValidParentheses
    {
        public bool isValid(string parentheses)
        {
            if (parentheses.Length > 100)
                Console.WriteLine("Length of parentheses not acceptable");

            int count = 0;
            foreach (var item in parentheses)
            {
                if (item == '(')
                    count++;
                if (item == ')')
                    count--;
                if(count < 0)
                    return false;
            }

            if (count == 0)
                return true;
            else
                return false;
        }
    }
}
