using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;

            ApplyButtonVisualEffects(this);
        }

        private void ApplyButtonVisualEffects(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.LightGray;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;

                    btn.MouseEnter += (s, e) => btn.BackColor = Color.SkyBlue;
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.LightGray;

                    btn.MouseDown += (s, e) => btn.BackColor = Color.SteelBlue;
                    btn.MouseUp += (s, e) => btn.BackColor = Color.SkyBlue;
                }
            }
        }

        private void ClearInputs()
        {
            txtBookID.Clear();
            txtBookTitle.Clear();
            txtAuthorName.Clear();
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                string selectedItem = listBoxBooks.SelectedItem.ToString();
                try
                {
                    string idPart = selectedItem.Split(':')[0];
                    string detailsPart = selectedItem.Split(':')[1];
                    string title = detailsPart.Split(new[] { " by " }, StringSplitOptions.None)[0].Trim();
                    string author = detailsPart.Split(new[] { " by " }, StringSplitOptions.None)[1].Trim();

                    txtBookID.Text = idPart;
                    txtBookTitle.Text = title;
                    txtAuthorName.Text = author;
                }
                catch {  }
            }
        }

        public async Task<List<string>> GetBooksAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                progress.Report(20);
                var books = await context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToListAsync();
                progress.Report(100);
                return books;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(v => progressBarOperation.Value = v);
            var books = await GetBooksAsync(progress);
            listBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string title, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = title, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveBookAsync(txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Saved successfully!");
                ClearInputs(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task UpdateBookAsync(int id, string title, string author)
        {
            using (var context = new BookstoreContext())
            {
                var bookEntry = await context.Books.Include(b => b.Author)
                    .FirstOrDefaultAsync(b => b.BookID == id);
                if (bookEntry != null)
                {
                    bookEntry.Title = title;
                    bookEntry.Author.Name = author;
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int id))
            {
                await UpdateBookAsync(id, txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Updated!");
                ClearInputs();
            }
        }

        public async Task DeleteBookAsync(int id)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(id);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int id))
            {
                await DeleteBookAsync(id);
                MessageBox.Show("Deleted!");
                ClearInputs();
            }
        }
    }
}