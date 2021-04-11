using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceOFMangoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mango(3, 3));
            Console.WriteLine(Mango(9, 5));
            Console.ReadLine();
        }

        public static int Mango(int quantity, int price)
        {
            return (quantity - (quantity / 3)) * price;
        }
    }
}
