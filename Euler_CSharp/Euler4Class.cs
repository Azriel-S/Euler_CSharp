using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_CSharp
{
	class Euler4Class
	{
		public int FindPalidromes(int sizeNum, out int val1, out int val2)
		{
			int maxVal = (int)Math.Pow((int)10, (int)sizeNum);
			int minVal = (int)Math.Pow((int)10, (int)(sizeNum - 1));
			val1 = val2 = 0;
			int largestPalidrome = 0;
			for (int i = minVal; i < maxVal - 1; ++i) {
				for (int j = i + 1; j < maxVal; ++j) {
					int result = i * j;
					string val = result.ToString();
					int valLenth = val.Length;
					int valSize;
					if (valLenth % 2 == 0)	// even number
						valSize = valLenth / 2;
					else
						valSize = (valLenth - 1) / 2;

					bool found = true;
					for (int k = 0; k < valSize; ++k) {
						if (val[k] != val[valLenth - k - 1]) {
							found = false;
							break;
						}
					}

					if (found) {
						if (result > largestPalidrome) {
							val1 = i;
							val2 = j;
							largestPalidrome = result;
						}
					}
				}
			}

			return largestPalidrome;
		}
	}
}
