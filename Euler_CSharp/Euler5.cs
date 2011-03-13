using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_CSharp
{
    class Euler5
    {
        public int FindEvenlyDivisible(int maxNumber)
        {
            int largestNum = 1;
            for (int i = 2; i <= maxNumber; ++i)
                largestNum *= i;

            int j = 2;
            while (j <= maxNumber)
            {
                int currentNum = largestNum / j;

                if (IsDivisible(maxNumber, currentNum))
                    largestNum = currentNum;
                else
                    j++;
            }

            return largestNum;
        }

        private bool IsDivisible(int maxNumber, int largestNum)
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
