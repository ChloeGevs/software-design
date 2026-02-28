using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public void AddAuthorWithBooks(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
            MessageBox.Show("Author and book added successfully!");
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        private void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                    MessageBox.Show("Book and author updated successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private void DeleteBookWithAuthors(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            {
                UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
                btnShowBooks_Click_1(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID.");
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookId.Text);
            AddAuthorWithBooks(txtAuthorName.Text, txtBookTitle.Text);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookId.Text, out int bookId))
            { 
                var confirmResult = MessageBox.Show("Are you sure to delete this book?",
                                             "Confirm Delete!!",
                                             MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteBookWithAuthors(bookId);
                    btnShowBooks_Click_1(sender, e);
                    txtBookId.Clear();
                    txtBookTitle.Clear();
                    txtAuthorName.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID to delete.");
            }
        }

        private void btnShowBooks_Click_1(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }
    }
}
