namespace lab5
{
    partial class BookStore
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
            txtBookId = new TextBox();
            btnUpdateBook = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnAddBook = new Button();
            btnShowBooks = new Button();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(319, 24);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(441, 324);
            listBoxBooks.TabIndex = 0;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(51, 44);
            txtBookId.Name = "txtBookId";
            txtBookId.PlaceholderText = "Book ID";
            txtBookId.Size = new Size(222, 27);
            txtBookId.TabIndex = 1;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.BackColor = Color.PaleGoldenrod;
            btnUpdateBook.Location = new Point(51, 280);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(222, 31);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = false;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(51, 118);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(222, 27);
            txtBookTitle.TabIndex = 3;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(51, 183);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Author Name";
            txtAuthorName.Size = new Size(222, 27);
            txtAuthorName.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.CornflowerBlue;
            btnAddBook.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddBook.Location = new Point(51, 243);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(222, 31);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.BackColor = Color.CornflowerBlue;
            btnShowBooks.Location = new Point(427, 368);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(222, 47);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = false;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.Firebrick;
            btnDeleteBook.Location = new Point(51, 317);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(222, 31);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Delete";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // BookStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnShowBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookId);
            Controls.Add(listBoxBooks);
            Name = "BookStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Store";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private TextBox txtBookId;
        private Button btnUpdateBook;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnAddBook;
        private Button btnShowBooks;
        private Button btnDeleteBook;
    }
}