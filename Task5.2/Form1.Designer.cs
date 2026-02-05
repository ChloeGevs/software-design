namespace Task5._2
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
            listBoxResults = new ListBox();
            btnSortDescending = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(311, 62);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(390, 324);
            listBoxResults.TabIndex = 0;
            // 
            // btnSortDescending
            // 
            btnSortDescending.Location = new Point(62, 62);
            btnSortDescending.Name = "btnSortDescending";
            btnSortDescending.Size = new Size(226, 53);
            btnSortDescending.TabIndex = 1;
            btnSortDescending.Text = "Sort";
            btnSortDescending.UseVisualStyleBackColor = true;
            btnSortDescending.Click += btnSortDescending_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSortDescending);
            Controls.Add(listBoxResults);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSortDescending;
    }
}
