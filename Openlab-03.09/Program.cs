using System;
using OpenLab_03._09;
namespace OpenLab_03._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 PrNumber = new Class1();

            for (int i = 0; i < 1000; i++)
                Console.WriteLine($"{i}: {PrNumber.IsPrimeNubmer(i)}");

            bool num = PrNumber.IsPrimeNubmer(9);
            Console.WriteLine(num);
        }
    }
}
