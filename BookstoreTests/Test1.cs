using lab4;

namespace BookstoreTests
{
    [TestClass]
    public class BookstoreTests
    {
        [TestMethod]
        public void TestPolymorphism()
        {
            Book[] books = new Book[]
            {
            new Book { Title = "C# Basics", Author = "John Doe" },
            new Magazine { Title = "Tech Weekly", IssueNumber = 12 },
            new Ebook { Title = "Learn Git", FileFormat = "PDF" }
            };

            Assert.AreEqual("Generic Book: C# Basics by John Doe", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn Git (Digital: PDF)", books[2].GetInfo());
        }

        [TestMethod]
        public void TestNegativeIssueNumber()
        {
            Magazine mag = new Magazine { Title = "Broken Mag", IssueNumber = -1 };

            string result = mag.GetInfo();

            Assert.AreEqual("Invalid Issue Number", result);
        }
    }
}
