using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_LINQ
{
    public static class IntExtensions
    {
        public static int Reverse(this int number) 
        {
            int reversedNumber = 0 ,Remainder;
            while (number !=0) 
            {
                Remainder = number % 10;
                reversedNumber = reversedNumber * 10 + Remainder;
                number = number / 10;
            }
            return reversedNumber;
        }
    }
}
