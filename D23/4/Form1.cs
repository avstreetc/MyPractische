using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string litter = textBox1.Text;

            if (litter == "К" || litter == "к")
            {
                button1.Visible = true;
            }
            else if (litter == "П" || litter == "п")
            {
                textBox4.Visible = true;
            }
            else if (litter == "М" || litter == "м")
            {
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("Не поддерживаемая буква");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
