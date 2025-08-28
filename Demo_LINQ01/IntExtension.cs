using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LINQ01
{
    //1234
    internal static class IntExtension
    {
        public static void Reverse( this int Number) 
        {
            int ReversedNumber  = 0, LastDigit;

            while (Number > 0) 
            {
                LastDigit = Number % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                Number /= 10;
            }

           // return ReversedNumber;

        }
    }
    //4321
}
