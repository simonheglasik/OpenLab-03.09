using System;
using OpenLab_03._09;
namespace OpenLab_03._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 PrNumber = new Class1();
            bool num = PrNumber.IsPrimeNubmer(5);
            Console.WriteLine(num);
        }
    }
}
