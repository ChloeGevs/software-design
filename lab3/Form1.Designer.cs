namespace lab3
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
            listBoxBooks = new ListBox();
            btnShowInfo = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(156, 36);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(475, 284);
            listBoxBooks.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(156, 337);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(283, 49);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(455, 337);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 49);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnShowInfo);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnShowInfo;
        private Button btnClear;
    }
}
