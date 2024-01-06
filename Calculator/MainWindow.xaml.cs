using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class CalcWindow : Window
    {
        private string previous = string.Empty;
        private string last = string.Empty;
        private string currentOperator = string.Empty;
        private double result = 0;

        public string Previous
        {
            get { return previous; }
            set
            {
                previous = value;
                PreviousTextBlock.Text = previous;
            }
        }

        public string Last
        {
            get { return last; }
            set
            {
                last = value;
                ResultTextBlock.Text = last;
            }
        }

        public CalcWindow()
        {
            InitializeComponent();
        }

        private void CleanEntryButton_Click(object sender, RoutedEventArgs e)
        {
            Last = "0";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Previous = string.Empty;
            Last = "0";
            currentOperator = string.Empty;
            result = 0;
        }

        private void ClearLastDigitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Last.Length == 1) Last = "0";
            else Last = Last.Remove(Last.Length - 1);
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Last.Contains(","))
                Last += ",";
        }

        private void DigitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Last == "0") Last = string.Empty;
            string digit = (string)((Button)sender).Content;
            Last += digit;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (Last != string.Empty)
            {
                currentOperator = (string)((Button)sender).Content;
                Previous = $"{Last}{currentOperator}";
                result = double.Parse(Last);
                CleanEntryButton_Click(sender, e);
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            Previous = string.Empty;
            currentOperator = string.Empty;
        }

        private void Calculate()
        {
            double secondOperand = double.Parse(Last);

            switch (currentOperator)
            {
                case "+":
                    result +=+ secondOperand;
                    break;
                case "-":
                    result -=  secondOperand;
                    break;
                case "*":
                    result *= secondOperand;
                    break;
                case "/":
                    if (secondOperand == 0)
                    {
                        Last = "0";
                        return;
                    }
                    result /= secondOperand;
                    break;
            }

            Last = result.ToString();
        }
    }
}
