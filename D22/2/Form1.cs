namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox3.Text += Environment.NewLine +
            "x = " + x.ToString();
            double b = double.Parse(textBox2.Text);
            textBox3.Text += Environment.NewLine +
            "b = " + b.ToString();

            double fx = Math.Pow(x, 2);
            double xb = x * b; // Вычисление произведения x и b

            double g;
            if (0.5 < xb && xb < 10)
            {
                g = Math.Exp(fx) - Math.Abs(b);
            }
            else if (0.1 < xb && xb <= 0.5)
            {
                g = Math.Sqrt(Math.Abs(fx + b));
            }
            else
            {
                g = 2 * Math.Pow(fx, 2);
            }

            textBox3.Text += Environment.NewLine + "g = " + g.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}