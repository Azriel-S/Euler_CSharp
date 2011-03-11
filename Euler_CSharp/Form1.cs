using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler_CSharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RunComboBox.Items.Clear();
            for (int i = 1; i < 5;++i )
                RunComboBox.Items.Add(i);
		}

		private void RunButton_Click(object sender, EventArgs e)
		{
			int index;
			if (Int32.TryParse(RunComboBox.Text, out index))
				RunEuler(index);
		}

		private void RunEuler(int index)
		{
			int startTime = Environment.TickCount;

            string result =String.Empty;
			switch (index)
			{
                case 1:
                    result = Euler1();
                    break;

                case 2:
                    result = Euler2();
                    break;

				case 3:
					result=Euler3();
					break;

				case 4:
					result = Euler4();
					break;
			}

            ResultLabel.Text = "Results:  " + result;
			int endTime = Environment.TickCount;
			TimingLabel.Text = "Timing:  " + (endTime - startTime).ToString();
		}

        private string Euler1()
        {
            Euler1 e1 = new Euler1();

            return e1.FindNaturalNumbers().ToString();
        }

        private string Euler2()
        {
            Euler2 e2 = new Euler2();

            return e2.SumEvens(4000000).ToString();
        }
        private string Euler3()
        {
            Int64 num = 600851475143;
            Int64 numSq = (Int64)Math.Sqrt((double)num);

            Euler3 e3 = new Euler3();
            e3.FindNPrimes(numSq);
            List<Int64> results = e3.FindDivisors(num);

            return results[results.Count - 1].ToString();
        }

        private string Euler4()
        {
            int val1, val2;
            Euler4Class e4 = new Euler4Class();
            int result = e4.FindPalidromes(3, out val1, out val2);

            return result.ToString();
        }

        
	}
}

