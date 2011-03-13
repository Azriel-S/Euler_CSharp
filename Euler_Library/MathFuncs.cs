using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_CSharp
{
    internal static class MathFuncs
    {
        internal static Int64 SumOfTheSquares(int maxNum)
        {
            Int64 total = 0;
            for (int i = 0; i <= maxNum; ++i)
                total += (Int64)Math.Pow((double)i, 2.0);

            return total;
        }

        internal static Int64 SquareOfTheSums(int maxNum)
        {
            Int64 total = 0;
            for (int i = 0; i <= maxNum; ++i)
                total += i;

            total = (Int64)Math.Pow((double)total, 2.0);

            return total;
        }
    }
}
