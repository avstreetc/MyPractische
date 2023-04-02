using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2,y2, r;

        private double a;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 0.1;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 + (int)(r * Math.Sin(a));
            Invalidate();
        }

        private Pen pen = new Pen(Brushes.Red, 2);
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            r = 150;
            a = 0;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;

            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 + (int)(r * Math.Sin(a));
            //timer1.Start();
        }

        private void Form_Poinr(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);
        }

    }
}
