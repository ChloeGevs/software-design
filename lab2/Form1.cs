namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Task 1: Recursive Factorial Implementation
        public long RecursiveFactorial(int n)
        {
            if (n <= 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void buttonCalculateFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int number))
            {
                if (number > 20)
                {
                    MessageBox.Show("Number too large for long result.");
                    return;
                }
                long result = RecursiveFactorial(number);
                labelResult.Text = $"Factorial: {result}";
            }
        }

        // Task 2: Sum of Array Elements Using Recursion
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n < 0) return 0; 
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = textBoxArrayInput.Text.Split(',')
                                .Select(s => int.Parse(s.Trim()))
                                .ToArray();

                int result = RecursiveSum(numbers, numbers.Length - 1);
                labelSumResult.Text = $"Sum: {result}";
            }
            catch
            {
                MessageBox.Show("Please enter numbers separated by commas (e.g., 1,2,3).");
            }
        }

        // Task 3: Fibonacci
        public long GetFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFibonacciInput.Text, out int n) && n >= 0)
            {
                if (n > 40)
                {
                    MessageBox.Show("Recursive Fibonacci is too slow for numbers this high!");
                    return;
                }
                long result = GetFibonacci(n);
                labelFibonacciResult.Text = $"Fibonacci: {result}";
            }
            else
            {
                labelFibonacciResult.Text = "Invalid input";
            }
        }

        // Recursive Power Calculation
        private long CalculatePower(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * CalculatePower(baseNum, exponent - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBase.Text, out int b) && int.TryParse(textBoxExponent.Text, out int exp))
            {
                if (exp < 0)
                {
                    MessageBox.Show("Please enter a non-negative exponent.");
                    return;
                }

                long result = CalculatePower(b, exp);
                labelPowerResult.Text = $"{b}^{exp} = {result}";
            }
        }
    }
}
