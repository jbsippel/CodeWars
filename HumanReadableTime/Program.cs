using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetReadableTime(1223));
            Console.ReadLine();
        }

        public static string GetReadableTime(int seconds)
        {
            int minutes = seconds / 60;
            int hours = minutes / 60;
            minutes = minutes % 60;
            seconds = seconds % 60;
            return string.Format("{0}:{1}:{2}", PadLeftZero(hours), PadLeftZero(minutes), PadLeftZero(seconds));
        }

        public static string PadLeftZero(int number)
        {
            return number.ToString().Count() > 1 ? number.ToString() : "0" + number.ToString();
        }
    }
}
