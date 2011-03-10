﻿using System;
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

        private void Euler3Button_Click(object sender, EventArgs e)
        {
			int startTime = Environment.TickCount;
			
			Int64 num = 600851475143;
			Int64 numSq =(Int64)Math.Sqrt((double) num);

			Euler3 e3 = new Euler3();
			e3.FindNPrimes(numSq);
			List<Int64> results = e3.FindDivisors(num);

			int endTime = Environment.TickCount;

			ResultLabel.Text = "Results:  " + results[results.Count-1].ToString();
			TimingLabel.Text = "Timing:  " + (endTime - startTime).ToString();
        }

		private void Euler4Button_Click(object sender, EventArgs e)
		{
			int startTime = Environment.TickCount;

			int val1, val2;
			Euler4Class e4 = new Euler4Class();
			int result = e4.FindPalidromes(3, out val1, out val2);
			
			int endTime = Environment.TickCount;

			ResultLabel.Text = "Results:  " + result.ToString();
			TimingLabel.Text = "Timing:  " + (endTime - startTime).ToString();
		}
    }
}

