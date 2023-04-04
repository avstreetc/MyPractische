using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int num1) && int.TryParse(textBox2.Text, out int num2))
            {
                // Вычисляем произведение чисел и выводим его в label4
                int result = num1 * num2;
                label4.Text = $"Ответ: {result}";
            }
            else
            {
                // Если в текстовых полях не числа, выводим сообщение об ошибке
                MessageBox.Show("Введите числа в оба текстовых поля");
            }
        }
    }
}
