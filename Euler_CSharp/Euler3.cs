using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_CSharp
{
    class Euler3
    {
		private System.Collections.Generic.List<Int64> m_primes;

        public Euler3()
        {
			m_primes = new List<Int64>();
			m_primes.Add(2);
			m_primes.Add(3);
        }

		public void FindNPrimes(Int64 largestPrime)
        {
			if (largestPrime <= 3)
				return;
			else {
				int maxPrimes = (int)Math.Sqrt((double)largestPrime);
				for (int currentNum = 5; currentNum < largestPrime; currentNum+=2) {
					for (int currentPrime = 0; m_primes[currentPrime] < maxPrimes; ++currentPrime) {
						if (currentNum % m_primes[currentPrime] != 0)
							break;
					}
					m_primes.Add(currentNum);
				}
			}
        }

		public List<Int64> FindDivisors(Int64 num)
		{
			System.Collections.Generic.List<Int64> divisors = new List<Int64>();

			for (int currentPrime = 0; currentPrime < m_primes.Count; ++currentPrime) {
				if (num % m_primes[currentPrime] == 0) {
					divisors.Add(m_primes[currentPrime]);
					num /= m_primes[currentPrime];
					while (num % m_primes[currentPrime] == 0)		// remove duplicates
						num /= m_primes[currentPrime];
				}
				if (num <= 0) break;
			}

			return divisors;
		}
    }
}
