using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class BookStore : Form
    {
        public BookStore()
        {
            InitializeComponent();
            // Wire the SelectedIndexChanged event
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
        }

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

        private void RefreshData()
        {
            using (var context = new BookstoreContext())
            {
                var books = context.Books.Include(b => b.Author).ToList();
                listBoxBooks.Items.Clear();
                foreach (var b in books)
                {
                    // Storing the ID in the string for easy parsing later
                    listBoxBooks.Items.Add($"ID: {b.BookID} - {b.Title} by {b.Author.Name}");
                }
            }
        }

        // Automatically populate textboxes when a book is clicked in the ListBox
        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem == null) return;

            string selectedItem = listBoxBooks.SelectedItem.ToString();
            try
            {
                // Parse the ID from the string "ID: [id] - [Title] by [Author]"
                int idStart = selectedItem.IndexOf("ID: ") + 4;
                int idEnd = selectedItem.IndexOf(" - ");
                string idString = selectedItem.Substring(idStart, idEnd - idStart);

                using (var context = new BookstoreContext())
                {
                    int bookId = int.Parse(idString);
                    var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                    if (book != null)
                    {
                        txtBookId.Text = book.BookID.ToString();
                        txtBookTitle.Text = book.Title;
                        txtAuthorName.Text = book.Author.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting book: " + ex.Message);
            }
        }

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
            ClearFields();
            RefreshData();
        }

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
                        ClearFields();
                        RefreshData();
                    }
                }
            }
        }

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
                            ClearFields();
                            RefreshData();
                        }
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtBookId.Clear();
            txtBookTitle.Clear();
            txtAuthorName.Clear();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}