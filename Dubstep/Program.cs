using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("WUBWUBABCWUB"));
            Console.ReadLine();
        }

        public static string SongDecoder(string str)
        {
            return string.Join(" ", str.Replace("WUB", " ").Split().Where(x => x != "").Select(x => x));
        }
    }
}
