namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);

            double x = x0;
            while (x <= (xk + dx / 2))
            {

                double y = Math.Pow(x, 2) + Math.Tan(5 * x + b / 4);
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; \ny=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;


            }
        }
    }
}