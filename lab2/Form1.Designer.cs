namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            buttonCalculateSum = new Button();
            labelResult = new Label();
            textBoxArrayInput = new TextBox();
            btnCalculateSum = new Button();
            labelSumResult = new Label();
            textBoxFibonacciInput = new TextBox();
            btnCalculateFibonacci = new Button();
            labelFibonacciResult = new Label();
            textBoxBase = new TextBox();
            btnCalculatePower = new Button();
            labelPowerResult = new Label();
            textBoxExponent = new TextBox();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(81, 40);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(231, 40);
            textBoxInput.TabIndex = 0;
            // 
            // buttonCalculateSum
            // 
            buttonCalculateSum.Location = new Point(117, 86);
            buttonCalculateSum.Name = "buttonCalculateSum";
            buttonCalculateSum.Size = new Size(170, 30);
            buttonCalculateSum.TabIndex = 1;
            buttonCalculateSum.Text = "Calculate";
            buttonCalculateSum.UseVisualStyleBackColor = true;
            buttonCalculateSum.Click += buttonCalculateFactorial_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(447, 43);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(49, 20);
            labelResult.TabIndex = 2;
            labelResult.Text = "Result";
            // 
            // textBoxArrayInput
            // 
            textBoxArrayInput.Location = new Point(81, 147);
            textBoxArrayInput.Multiline = true;
            textBoxArrayInput.Name = "textBoxArrayInput";
            textBoxArrayInput.Size = new Size(231, 40);
            textBoxArrayInput.TabIndex = 3;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(117, 193);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(170, 30);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // labelSumResult
            // 
            labelSumResult.AutoSize = true;
            labelSumResult.Location = new Point(447, 150);
            labelSumResult.Name = "labelSumResult";
            labelSumResult.Size = new Size(49, 20);
            labelSumResult.TabIndex = 5;
            labelSumResult.Text = "Result";
            // 
            // textBoxFibonacciInput
            // 
            textBoxFibonacciInput.Location = new Point(81, 244);
            textBoxFibonacciInput.Multiline = true;
            textBoxFibonacciInput.Name = "textBoxFibonacciInput";
            textBoxFibonacciInput.Size = new Size(231, 40);
            textBoxFibonacciInput.TabIndex = 6;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(117, 290);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(170, 30);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // labelFibonacciResult
            // 
            labelFibonacciResult.AutoSize = true;
            labelFibonacciResult.Location = new Point(447, 247);
            labelFibonacciResult.Name = "labelFibonacciResult";
            labelFibonacciResult.Size = new Size(49, 20);
            labelFibonacciResult.TabIndex = 8;
            labelFibonacciResult.Text = "Result";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(81, 342);
            textBoxBase.Multiline = true;
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(105, 40);
            textBoxBase.TabIndex = 9;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(117, 388);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(170, 30);
            btnCalculatePower.TabIndex = 10;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // labelPowerResult
            // 
            labelPowerResult.AutoSize = true;
            labelPowerResult.Location = new Point(447, 345);
            labelPowerResult.Name = "labelPowerResult";
            labelPowerResult.Size = new Size(49, 20);
            labelPowerResult.TabIndex = 11;
            labelPowerResult.Text = "Result";
            // 
            // textBoxExponent
            // 
            textBoxExponent.Location = new Point(214, 342);
            textBoxExponent.Multiline = true;
            textBoxExponent.Name = "textBoxExponent";
            textBoxExponent.Size = new Size(98, 40);
            textBoxExponent.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxExponent);
            Controls.Add(labelPowerResult);
            Controls.Add(btnCalculatePower);
            Controls.Add(textBoxBase);
            Controls.Add(labelFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(textBoxFibonacciInput);
            Controls.Add(labelSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(textBoxArrayInput);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculateSum);
            Controls.Add(textBoxInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonCalculateSum;
        private Label labelResult;
        private TextBox textBoxArrayInput;
        private Button btnCalculateSum;
        private Label labelSumResult;
        private TextBox textBoxFibonacciInput;
        private Button btnCalculateFibonacci;
        private Label labelFibonacciResult;
        private TextBox textBoxBase;
        private Button btnCalculatePower;
        private Label labelPowerResult;
        private TextBox textBoxExponent;
    }
}
