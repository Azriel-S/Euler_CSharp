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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TimingLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.RunComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(161, 52);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 17);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "Results:";
            // 
            // TimingLabel
            // 
            this.TimingLabel.AutoSize = true;
            this.TimingLabel.Location = new System.Drawing.Point(161, 79);
            this.TimingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimingLabel.Name = "TimingLabel";
            this.TimingLabel.Size = new System.Drawing.Size(54, 17);
            this.TimingLabel.TabIndex = 2;
            this.TimingLabel.Text = "Timing:";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(164, 10);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 28);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // RunComboBox
            // 
            this.RunComboBox.FormattingEnabled = true;
            this.RunComboBox.Location = new System.Drawing.Point(13, 13);
            this.RunComboBox.Name = "RunComboBox";
            this.RunComboBox.Size = new System.Drawing.Size(121, 24);
            this.RunComboBox.TabIndex = 5;
            this.RunComboBox.SelectedIndexChanged += new System.EventHandler(this.RunComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.RunComboBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.TimingLabel);
            this.Controls.Add(this.ResultLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label TimingLabel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ComboBox RunComboBox;
    }
}

