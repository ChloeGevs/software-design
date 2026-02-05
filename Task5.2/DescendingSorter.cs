using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._2
{
    public class DescendingSorter
    {
        public void Sort(int[] data)
        {
            Array.Sort(data);
            Array.Reverse(data);
        }
    }
}
