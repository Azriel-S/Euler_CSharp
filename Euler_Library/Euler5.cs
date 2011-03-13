using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_Library
{
    public class Euler5
    {
        public int FindEvenlyDivisible(int maxNumber)
        {
            Int64 largestNum = 1;
            for (int i = 2; i <= maxNumber; ++i)
                largestNum *= i;

            int j = 2;
            while (j <= maxNumber)
            {
                Int64 currentNum = largestNum / j;

                if (IsDivisible(maxNumber, currentNum))
                    largestNum = currentNum;
                else
                    j++;
            }

            return (int)largestNum;
        }

        private bool IsDivisible(int maxNumber, Int64 largestNum)
        {
            for (int i = 2; i <= maxNumber; ++i)
            {
                if (largestNum % i != 0)
                    return false;
            }

            return true;
        }
    }
}
