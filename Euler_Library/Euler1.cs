﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_Library
{
    public class Euler1
    {
        public int FindNaturalNumbers()
        {
            int total = 0;
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
