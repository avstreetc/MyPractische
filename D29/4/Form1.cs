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
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        public Form1()
        {
            InitializeComponent();
            try
            {
                baner = new Bitmap("plane.png");
            }
            catch (Exception e)
            {

                MessageBox.Show($"Ошибка загрузки файла баннер\n {e.ToString()} Баннер");
                this.Close();
                return;
            }
            rct.X = 0;
            rct.Y = this.ClientSize.Height;
            rct.Width = baner.Width;
            rct.Height = baner.Height;

            this.Paint += Form1_Paint;
          
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            timer1.Enabled = false;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(plane, rect);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (rct.X > this.ClientSize.Width || rct.Y < -rct.Height)
            {
                rct.X = 0;
                rct.Y = this.ClientSize.Height;
            }

            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(baner, rct.X + i * rct.Width, rct.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X += 1;
            rct.Y -= 1;
            Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
