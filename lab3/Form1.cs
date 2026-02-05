namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Task 2: Polymorphic Behavior
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] inventory = new Book[]
            {
                new Magazine { Title = "National Geographic", IssueNumber = 202 },
                new Ebook { Title = "C# Design Patterns", Author = "Steve Smith", FileSizeMB = 1.5 },
                new Textbook { Title = "University Physics", Author = "Young & Freedman", Subject = "Science" },
                new AudioBook { Title = "The Hobbit", Author = "J.R.R. Tolkien", Narrator = "Andy Serkis", DurationHours = 10.5 }
            };

            listBoxBooks.Items.Clear();

            foreach (Book item in inventory)
            {
                listBoxBooks.Items.Add(item.GetInfo());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
        }
    }

    // Task 1: Base Class

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public virtual string GetInfo()
        {
            return $"[Book] {Title} by {Author}";
        }
    }

    // Task 1: Subclasses
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }
        public override string GetInfo()
        {
            return $"[Magazine]: {Title}, Issue #{IssueNumber}";
        }
    }

    public class Ebook : Book
    {
        public double FileSizeMB { get; set; }
        public override string GetInfo()
        {
            return $"[Ebook]: {Title} ({FileSizeMB}MB)";
        }
    }

    // Task 3: Student Challenge Subclasses
    public class Textbook : Book
    {
        public string Subject { get; set; }
        public override string GetInfo()
        {
            return $"[Textbook]: {Title}, Subject: {Subject}";
        }
    }

    public class AudioBook : Book
    {
        public string Narrator { get; set; }
        public double DurationHours { get; set; }
        public override string GetInfo()
        {
            return $"[Audio]: {Title}, Narrator: {Narrator} ({DurationHours} hrs)";
        }
    }
}

