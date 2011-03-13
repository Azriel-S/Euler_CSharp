using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Euler_Library
{
    public class Euler2
    {
        public long SumEvens(int maxVal)
        {
            return GenerateFibinacci(maxVal).Where(n => n % 2 == 0)
                .Sum();
        }

        private IEnumerable<long> GenerateFibinacci(int maxVal)
        {
            int val1 = 0;
            int val2 = 1;
            int total;
            do
            {
                total = val1 + val2;
                val1 = val2;
                val2 = total;
                yield return total;
            } while (total < maxVal);
        }
    }
}
