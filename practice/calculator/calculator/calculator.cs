namespace calculator
{
    public partial class calculator : Form
    {
        private decimal valufirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void zerobtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "0";
            }
            else
                TxtBtn.Text += "0";
        }

        private void cleatBtn_Click(object sender, EventArgs e)
        {
            valufirst = 0.0m;
            valuesecond = 0.0m;
            TxtBtn.Text = "0";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBtn.Text.Contains("."))
            {
                TxtBtn.Text += ".";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "1";
            }
            else
            {
                TxtBtn.Text += "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "2";
            }
            else
            {
                TxtBtn.Text += "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "3";
            }
            else
            {
                TxtBtn.Text += "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "4";
            }
            else
            {
                TxtBtn.Text += "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "5";
            }
            else
            {
                TxtBtn.Text += "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "6";
            }
            else
            {
                TxtBtn.Text += "6";
            }
        }

        private void seveenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "7";
            }
            else
            {
                TxtBtn.Text += "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "8";
            }
            else
            {
                TxtBtn.Text += "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text == "0")
            {
                TxtBtn.Text = "9";
            }
            else
            {
                TxtBtn.Text += "9";
            }
        }

        private void minuandplusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBtn.Text.Contains("-"))
            {
                TxtBtn.Text = TxtBtn.Text.Trim('-');
            }
            else
            {
                TxtBtn.Text = "-" + TxtBtn.Text;
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            valufirst = decimal.Parse(TxtBtn.Text);
            TxtBtn.Clear();
            operators = "+";

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            valufirst = decimal.Parse(TxtBtn.Text);
            TxtBtn.Clear();
            operators = "-";
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            valufirst = decimal.Parse(TxtBtn.Text);
            TxtBtn.Clear();
            operators = "%";
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            valufirst = decimal.Parse(TxtBtn.Text);
            TxtBtn.Clear();
            operators = "*";
        }

        private void dividBtn_Click(object sender, EventArgs e)
        {
            valufirst = decimal.Parse(TxtBtn.Text);
            TxtBtn.Clear();
            operators = "/";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valuesecond = decimal.Parse(TxtBtn.Text);
                    result = valufirst + valuesecond;
                    TxtBtn.Text = result.ToString();
                    break;
                case "-":
                    valuesecond = decimal.Parse(TxtBtn.Text);
                    result = valufirst - valuesecond;
                    TxtBtn.Text = result.ToString();
                    break;
                case "*":
                    valuesecond = decimal.Parse(TxtBtn.Text);
                    result = valufirst * valuesecond;
                    TxtBtn.Text = result.ToString();
                    break;
                case "/":
                    valuesecond = decimal.Parse(TxtBtn.Text);
                    result = valufirst / valuesecond;
                    TxtBtn.Text = result.ToString();
                    break;
                case "%":
                    valuesecond = decimal.Parse(TxtBtn.Text);
                    result = valufirst % valuesecond;
                    TxtBtn.Text = result.ToString();
                    break;
            }
        }
    }
}
