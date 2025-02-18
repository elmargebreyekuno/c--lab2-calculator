namespace calculator
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            calculator.Equals(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "1");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oj nu blir det så hög siffra som jag inte kan hantera :(");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = 0;
                calculator.prev = 0;
                label2.Text = "";
                label1.Text = "0";
            }
            catch (Exception ex)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculator.Next("+", label1, label2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "2");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculator.Next("-", label1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "3");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "0");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calculator.Next("/", label1, label2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calculator.Next("x", label1, label2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculator.Next("=", label1, label2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "4");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "5");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.curr = int.Parse(calculator.curr.ToString() + "6");
                label1.Text = calculator.curr.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}