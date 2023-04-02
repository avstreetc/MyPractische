using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
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
                baner = new Bitmap("baner.png");
            }
            catch (Exception e)
            {

                MessageBox.Show($"Ошибка загрузки файла баннер\n {e.ToString()} Баннер");
                this.Close();
                return;
            }
            rct.X = 0;
            rct.Y = 0;
            rct.Width = baner.Width;
            rct.Height = baner.Height;

            this.Paint += Form1_Paint;
            this.MouseMove += Form1_MouseMove;
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            timer1.Enabled = true;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Math.Abs(rct.X) > rct.Width)
                rct.X += rct.Width;
            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(baner, rct.X + 1 * rct.Width, rct.Y);
            }
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            rct.X -= 1;
            Invalidate();
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                
                    timer1.Enabled = false;
            }
            else
            {
               
                    timer1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }
    }
}
