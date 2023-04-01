using System.Globalization;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = string.Empty;
            int count = 0;

            // Получаем введенную строку из списка
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                inputString += listBox1.Items[i].ToString() + " ";
            }

            // Считаем количество строчных русских букв в строке
            foreach (char c in inputString)
            {
                if (c >= 'а' && c <= 'я')
                {
                    count++;
                }
            }
            // Выводим результат на метку
            label1.Text = "Количество строчных русских букв: " + count.ToString();

        }
    }
}