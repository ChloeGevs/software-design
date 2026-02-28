using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Define Entity Models inside the namespace or class
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        // Helper method to refresh the display
        private void RefreshData()
        {
            using (var context = new BookstoreContext())
            {
                var books = context.Books.Include(b => b.Author).ToList();
                listBoxBooks.Items.Clear();
                foreach (var b in books)
                {
                    listBoxBooks.Items.Add($"ID: {b.BookID} - {b.Title} by {b.Author.Name}");
                }
            }
        }

        // Task 5: Add a New Author and Book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAuthorName.Text) || string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = txtAuthorName.Text };
                var book = new Book { Title = txtBookTitle.Text, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("Saved successfully!");
            }
            RefreshData();
        }

        // Task 5: Display All Books
        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        // Task 6: Update Book and Author Information
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                using (var context = new BookstoreContext())
                {
                    var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                    if (book != null)
                    {
                        book.Title = txtBookTitle.Text;
                        book.Author.Name = txtAuthorName.Text;
                        context.SaveChanges();
                        MessageBox.Show("Updated successfully!");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid numeric Book ID.");
            }
        }

        // Task 7: Student Challenge - Delete a Book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                var confirm = MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var context = new BookstoreContext())
                    {
                        var book = context.Books.Find(bookId);
                        if (book != null)
                        {
                            context.Books.Remove(book);
                            context.SaveChanges();
                            MessageBox.Show("Deleted successfully!");
                            RefreshData();
                        }
                    }
                }
            }
        }
    }
}