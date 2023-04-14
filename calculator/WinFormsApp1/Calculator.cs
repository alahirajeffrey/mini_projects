namespace WinFormsApp1
{
    public partial class Calculator : Form
    {

        private Double firstNumber = 0;
        private Double secondNumber = 0;
        private Double result = 0;
        private String operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // add a decimal point if textbox does not already contain it
            if (!textBox.Text.Contains('.'))
            {
                textBox.Text += ".";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("-"))
            {
                textBox.Text = textBox.Text.Trim('-');
            }
            else
            {
                textBox.Text = '-' + textBox.Text;
            }
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox.Text);
            textBox.Clear();
            operation = "-";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox.Text);
            textBox.Clear();
            operation = "+";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox.Text);
            textBox.Clear();
            operation = "*";
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox.Text);
            textBox.Clear();
            operation = "/";
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(textBox.Text);
            textBox.Clear();
            operation = "%";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "-":
                    secondNumber = Double.Parse(textBox.Text);
                    result = firstNumber - secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case "+":
                    secondNumber = Double.Parse(textBox.Text);
                    result = firstNumber + secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case "*":
                    secondNumber = Double.Parse(textBox.Text);
                    result = firstNumber * secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case "/":
                    secondNumber = Double.Parse(textBox.Text);
                    result = firstNumber / secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case "%":
                    secondNumber = Double.Parse(textBox.Text);
                    result = firstNumber % secondNumber;
                    textBox.Text = result.ToString();
                    break;
            }
        }
    }
}