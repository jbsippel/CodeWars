using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplementaryDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeComplement("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA"));
            Console.ReadLine();
        }

        public static string MakeComplement(string dna)
        {
            string dnaComplement = "";
            foreach (var letter in dna)
            {
                switch (letter)
                {
                    case 'A':
                        dnaComplement += "T";
                        break;
                    case 'T':
                        dnaComplement += "A";
                        break;
                    case 'C':
                        dnaComplement += "G";
                        break;
                    case 'G':
                        dnaComplement += "C";
                        break;
                }
            }
            return dnaComplement;
        }
    }
}
