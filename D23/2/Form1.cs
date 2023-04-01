using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = double.Parse(textBox1.Text);
            double xmax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((xmax - xmin) / step) + 1;
            double[] y1 = new double[count];
            double[] x = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = xmin + step * i;
                y1[i] = Math.Pow(x[i],2);
            }
            chart2.ChartAreas[0].AxisX.Minimum = xmin;
            chart2.ChartAreas[0].AxisX.Maximum = xmax;

            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = step;

            chart2.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
