namespace lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            txtBookID = new TextBox();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            progressBarOperation = new ProgressBar();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(49, 44);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(118, 41);
            btnFetchBooks.TabIndex = 8;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(49, 91);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(386, 144);
            listBoxBooks.TabIndex = 7;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(62, 302);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(360, 27);
            txtAuthorName.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(62, 332);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(360, 27);
            txtBookTitle.TabIndex = 4;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(62, 269);
            txtBookID.Name = "txtBookID";
            txtBookID.PlaceholderText = "Enter Book ID for Update/Delete";
            txtBookID.Size = new Size(360, 27);
            txtBookID.TabIndex = 6;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(54, 367);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(118, 43);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add Book";
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(178, 367);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(128, 43);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(312, 367);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(110, 43);
            btnDeleteBook.TabIndex = 1;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // progressBarOperation
            // 
            progressBarOperation.Location = new Point(33, 432);
            progressBarOperation.Name = "progressBarOperation";
            progressBarOperation.Size = new Size(414, 23);
            progressBarOperation.TabIndex = 0;
            // 
            // Form1
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(490, 467);
            Controls.Add(progressBarOperation);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookID);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore Event-Driven & Async";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnFetchBooks;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.ProgressBar progressBarOperation;
    }
}