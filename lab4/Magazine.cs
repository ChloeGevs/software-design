using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            if (IssueNumber < 0) return "Invalid Issue Number";
            return $"{Title} - Issue {IssueNumber}";
        }
    }
}
