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

		private void Euler3()
		{
			Int64 num = 600851475143;
			Int64 numSq = (Int64)Math.Sqrt((double)num);

			Euler3 e3 = new Euler3();
			e3.FindNPrimes(numSq);
			List<Int64> results = e3.FindDivisors(num);

			ResultLabel.Text = "Results:  " + results[results.Count - 1].ToString();
		}

		private void Euler4(){
			int val1, val2;
			Euler4Class e4 = new Euler4Class();
			int result = e4.FindPalidromes(3, out val1, out val2);
			
			ResultLabel.Text = "Results:  " + result.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RunComboBox.Items.Clear();
			RunComboBox.Items.Add(3);
			RunComboBox.Items.Add(4);
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

			switch (index)
			{
				case 3:
					Euler3();
					break;

				case 4:
					Euler4();
					break;
			}

			int endTime = Environment.TickCount;
			TimingLabel.Text = "Timing:  " + (endTime - startTime).ToString();
		}
	}
}

