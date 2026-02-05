using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Ebook : Book
    {
        public string FileFormat { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Digital: {FileFormat})";
        }
    }
}
