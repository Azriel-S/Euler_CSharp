namespace Euler_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.Euler3Button = new System.Windows.Forms.Button();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.TimingLabel = new System.Windows.Forms.Label();
			this.Euler4Button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Euler3Button
			// 
			this.Euler3Button.Location = new System.Drawing.Point(2, 37);
			this.Euler3Button.Name = "Euler3Button";
			this.Euler3Button.Size = new System.Drawing.Size(75, 23);
			this.Euler3Button.TabIndex = 0;
			this.Euler3Button.Text = "Euler3";
			this.Euler3Button.UseVisualStyleBackColor = true;
			this.Euler3Button.Click += new System.EventHandler(this.Euler3Button_Click);
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(121, 42);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(45, 13);
			this.ResultLabel.TabIndex = 1;
			this.ResultLabel.Text = "Results:";
			// 
			// TimingLabel
			// 
			this.TimingLabel.AutoSize = true;
			this.TimingLabel.Location = new System.Drawing.Point(121, 64);
			this.TimingLabel.Name = "TimingLabel";
			this.TimingLabel.Size = new System.Drawing.Size(41, 13);
			this.TimingLabel.TabIndex = 2;
			this.TimingLabel.Text = "Timing:";
			// 
			// Euler4Button
			// 
			this.Euler4Button.Location = new System.Drawing.Point(2, 76);
			this.Euler4Button.Name = "Euler4Button";
			this.Euler4Button.Size = new System.Drawing.Size(75, 23);
			this.Euler4Button.TabIndex = 3;
			this.Euler4Button.Text = "Euler 4";
			this.Euler4Button.UseVisualStyleBackColor = true;
			this.Euler4Button.Click += new System.EventHandler(this.Euler4Button_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.Euler4Button);
			this.Controls.Add(this.TimingLabel);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.Euler3Button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Euler3Button;
        private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Label TimingLabel;
		private System.Windows.Forms.Button Euler4Button;
    }
}

