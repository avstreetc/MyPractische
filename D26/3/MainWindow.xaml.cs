using System.Windows;
using System.Xml.Linq;

public partial class LibraryWindow : Window
{
    public LibraryWindow()
    {
        InitializeComponent();

        // Загружаем XML-файл "Библиотека"
        XDocument doc = XDocument.Load("Library.xml");

        // Преобразуем каждый элемент "Book" в объект Book и добавляем его в ListBox
        foreach (XElement element in doc.Root.Elements("Book"))
        {
            Book book = new()
            {
                Title = element.Element("Title").Value,
                Author = element.Element("Author").Value,
                Year = element.Element("Year").Value
            };
            booksList.Items.Add(book);
        }
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Year { get; set; }
}
