using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        private string currentInput = "";
        private double result = 0;
        private string operation = "";
        private bool isNewNumber = true;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (isNewNumber)
            {
                displayTextBox.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                displayTextBox.Text += button.Text;
            }
            currentInput = displayTextBox.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(currentInput))
            {
                if (result == 0)
                {
                    result = double.Parse(currentInput);
                }
                else if (!isNewNumber)
                {
                    CalculateResult();
                }
                operation = button.Text;
                isNewNumber = true;
                displayTextBox.Text += operation;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) && !isNewNumber)
            {
                CalculateResult();
                operation = "";
                isNewNumber = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            isNewNumber = true;
            displayTextBox.Text = "";
        }

        private void CalculateResult()
        {
            double number = double.Parse(currentInput);
            switch (operation)
            {
                case "+":
                    result += number;
                    break;
                case "-":
                    result -= number;
                    break;
                case "*":
                    result *= number;
                    break;
                case "/":
                    if (number != 0)
                        result /= number;
                    else
                        MessageBox.Show("除数不能为零！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            displayTextBox.Text = result.ToString();
            currentInput = result.ToString();
        }
    }
}