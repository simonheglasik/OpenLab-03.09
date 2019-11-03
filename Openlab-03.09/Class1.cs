using System;
using System.Collections.Generic;
using System.Text;

namespace OpenLab_03._09
{
    class Class1
    {
        public bool IsPrimeNubmer(int number)
        {
            if (number == 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
