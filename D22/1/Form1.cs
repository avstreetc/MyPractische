namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "16,55"; // * Math.Pow(10,-3)
            textBox2.Text = "-2,75";
            textBox3.Text = "0,15";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);

            textBox4.Text += Environment.NewLine +
            "x = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
            "y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
            "z = " + z.ToString();
            double B = (Math.Sqrt(10 * (Math.Pow((x * Math.Pow(10, -3)), 1 / 2) + Math.Pow((x * Math.Pow(10, -3)), (y + 2))))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs((x * Math.Pow(10, -3)) - y));
            textBox4.Text += Environment.NewLine +

            "B = " + B.ToString();

        }
    }
}