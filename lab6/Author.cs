using System.Collections.Generic;

namespace lab6
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}