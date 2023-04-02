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
using System.Xml.Linq;

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Загружаем XML-файл "Библиотека"
            XDocument doc = XDocument.Load("counties.xml");

            // Преобразуем каждый элемент "Book" в объект Book и добавляем его в ListBox
            foreach (XElement element in doc.Root.Elements("Voksal"))
            {
                Voksal voksal = new Voksal()
                {
                    Point = element.Element("Point").Value,
                    Nummer = element.Element("Nummer").Value,
                    PointOf = element.Element("PointOf").Value
                };
                VoksalsList.Items.Add(voksal);
            }
        }
    }
}
public class Voksal
{
    public string Point { get; set; }
    public string Nummer { get; set; }
    public string PointOf { get; set; }
}
