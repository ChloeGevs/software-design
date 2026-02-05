namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ArraySorter
        {
            public void SortData(int[] numbers)
            {
                Array.Sort(numbers);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] myNumbers = {3, 1, 5, 2, 4};
            ArraySorter sorter = new ArraySorter();

            sorter.SortData(myNumbers);

            foreach (int num in myNumbers)
            {
                listBoxResults.Items.Add(num);
            }
        }
    }
}
