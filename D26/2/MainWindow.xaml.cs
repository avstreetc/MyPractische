using System.Windows;
using System.Xml.Linq;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Загружаем XML-файл "Библиотека"
        XDocument doc = XDocument.Load("counties.xml");

        // Преобразуем каждый элемент  и добавляем его в ListBox
        foreach (XElement element in doc.Root.Elements("Voksal"))
        {
            Voksal voksal = new Voksal()
            {
                Point = element.Element("Point").Value,
                Nummer = element.Element("Nummer").Value,
                PointOf = element.Element("PointOf").Value
            };
            voksalsList.Items.Add(voksal);
        }
    }
}

public class Voksal
{
    public string Point { get; set; }
    public string Nummer { get; set; }
    public string PointOf { get; set; }
}
