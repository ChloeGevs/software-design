namespace Task5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortDescending_Click(object sender, EventArgs e)
        {
            int[] numbers = { 25, 7, 80, 13, 2 };
            DescendingSorter sorter = new DescendingSorter();
            
            sorter.Sort(numbers);

            listBoxResults.Items.Clear();
            foreach (int number in numbers)
            {
                listBoxResults.Items.Add(number);
            }
        }
    }
}
