using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_CSharp
{
    class Euler1
    {
        public long FindNaturalNumbers()
        {
            long total = 0;
            for (int i = 3; i < 1000; ++i)
            {
                if (i % 3 == 0)
                    total += i;
                else if (i % 5 == 0)
                    total += i;
            }

            return total;
        }
    }
}
