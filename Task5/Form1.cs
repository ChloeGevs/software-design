namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = arr.Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            listBoxResults.Items.Clear();
            foreach (int item in arr) listBoxResults.Items.Add(item);
        }
    }
}
