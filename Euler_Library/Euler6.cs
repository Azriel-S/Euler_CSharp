using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_Library
{
    public class Euler6Class
    {
        public Int64 DiffOfSquares(int maxNum)
        {
            Int64 square = MathFuncs.SquareOfTheSums(maxNum);
            Int64 sum = MathFuncs.SumOfTheSquares(maxNum);

            return square - sum;
        }

    }
}
