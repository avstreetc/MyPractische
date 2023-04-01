namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //код рисования

            //моник экран
            int monitorWidth = 200;
            int monitorHeight = 160;
            int monitorX = 50;
            int monitorY = 50;

            // рамку монитора и нога
            g.DrawRectangle(Pens.Black, monitorX, monitorY, monitorWidth, monitorHeight);
            g.FillRectangle(Brushes.Black, monitorX + monitorWidth / 2 - 10, monitorY + monitorHeight, 20, 40);


            // Рисуем экран монитора
            int screenX = monitorX + 10;
            int screenY = monitorY + 10;
            int screenWidth = monitorWidth - 20;
            int screenHeight = monitorHeight - 20;
            g.FillRectangle(Brushes.Black, screenX, screenY, screenWidth, screenHeight);

            // Рисуем логотип windos на экране монитора
            int logoWidth = 15;
            int logoHeight = 15;
            int logoX = screenX + screenWidth / 2 - logoWidth / 2;
            int logoY = screenY + screenHeight / 2 - logoHeight / 2;
            int logoPadding = 2;
            g.FillRectangle(Brushes.White, logoX, logoY, logoWidth, logoHeight);
            g.FillRectangle(Brushes.White, logoX + logoWidth + logoPadding, logoY, logoWidth, logoHeight);
            g.FillRectangle(Brushes.White, logoX, logoY + logoHeight + logoPadding, logoWidth, logoHeight);
            g.FillRectangle(Brushes.White, logoX + logoWidth + logoPadding, logoY + logoHeight + logoPadding, logoWidth, logoHeight);
        }


    }
}