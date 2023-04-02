using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DrawingVisual visual = new DrawingVisual();
            using (DrawingContext dc = visual.RenderOpen())
            {
                // Нарисовать треугольник
                Point p1 = new Point(10, 10);
                Point p2 = new Point(50, 50);
                Point p3 = new Point(10, 50);
                PathFigure pathFigure = new PathFigure();
                pathFigure.StartPoint = p1;
                pathFigure.Segments.Add(new LineSegment(p2, true));
                pathFigure.Segments.Add(new LineSegment(p3, true));
                PathGeometry pathGeometry = new PathGeometry();
                pathGeometry.Figures.Add(pathFigure);
                dc.DrawGeometry(Brushes.Black, new Pen(Brushes.Black, 2), pathGeometry);

                // Нарисовать эллипс
                Rect rect = new Rect(70, 10, 40, 60);
                dc.DrawEllipse(Brushes.Red, new Pen(Brushes.Blue, 2), new Point(80, 90), 40, 30); // Center="50,50" RadiusX="40" RadiusY="30"

                // Нарисовать закрашенный круг
                dc.DrawEllipse(Brushes.Green, new Pen(Brushes.Yellow, 2), new Point(140, 40), 30, 30);

                // Нарисовать закрашенный прямоугольник
                dc.DrawRectangle(Brushes.Purple, new Pen(Brushes.Black, 2), new Rect(180, 10, 60, 40));

                // Нарисовать сектор
                Point center = new Point(280, 40);
                double radius = 30;
                double startAngle = 30;
                double endAngle = 330;
                bool isLargeArc = endAngle - startAngle > 180;
                Size size = new Size(radius, radius);
                Point startPoint = new Point(center.X + radius * Math.Cos(startAngle * Math.PI / 180),
                                             center.Y + radius * Math.Sin(startAngle * Math.PI / 180));
                Point endPoint = new Point(center.X + radius * Math.Cos(endAngle * Math.PI / 180),
                                           center.Y + radius * Math.Sin(endAngle * Math.PI / 180));
                PathFigure sectorFigure = new PathFigure();
                sectorFigure.StartPoint = center;
                sectorFigure.Segments.Add(new LineSegment(startPoint, true));
                sectorFigure.Segments.Add(new ArcSegment(endPoint, size, 0, isLargeArc, SweepDirection.Clockwise, true));
                sectorFigure.Segments.Add(new LineSegment(center, true));
                PathGeometry sectorGeometry = new PathGeometry();
                sectorGeometry.Figures.Add(sectorFigure);
                dc.DrawGeometry(Brushes.Orange, new Pen(Brushes.Black, 2), sectorGeometry);
            }
            DrawingVisualHost host = new DrawingVisualHost(visual);
            this.Content = host;
        }
    }

    public class DrawingVisualHost : FrameworkElement
    {
        private DrawingVisual _visual;

        public DrawingVisualHost(DrawingVisual visual)
        {
            _visual = visual;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            drawingContext.DrawDrawing(_visual.Drawing);
        }
    }
}
