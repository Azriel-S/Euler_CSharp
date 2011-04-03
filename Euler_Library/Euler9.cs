using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Euler_Library
{
    public class Euler9
    {
        public int Pythag_Triplet(int maxNum)
        {
            m_maxVal = maxNum;

            if (CountUp())
                return a * b * c;
            else
                return -1;
        }

        int m_maxVal, a, b, c;

        private bool CountUp()
        {
            for (a = 1; a < m_maxVal; ++a)
            {
                b = a + 1;
                c = b + 1;
                if (CheckPythag()) return true;
            }
            return false;
        }

        private bool CheckPythag()
        {
            do
            {
                int ls = a * a + b * b;
                int rs = c * c;

                if (ls < rs)
                {
                    if (!Increment(ref b)) return false;
                }
                else if (ls > rs)
                {
                    if (!Increment(ref c)) return false;
                }
                else
                {
                    if (CheckVal()) return true;
                }
            } while(c <= m_maxVal);

            return false;
        }

        // a = 3, b = 4, c = 5

        private bool CheckVal()
        {
            int ls = a + b + c;
            if (ls == m_maxVal)
                return true;
            else if (ls < m_maxVal)
            {
                Increment(ref c);
                return false;
            }
            else
            {
                c = m_maxVal + 1;
                return false;
            }
        }

        private bool Increment(ref int val)
        {
            val++;
            if (val > m_maxVal)
                return false;
            else
                return true;
        }
    }
}
