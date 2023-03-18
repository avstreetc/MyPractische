using System;

// Класс "Книга"
class Book : IComparable<Book>
{
    // Поля книги
    public string title;
    public string author;
    public int year;

    // Конструктор книги
    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    // Реализация интерфейса IComparable для сравнения по году издания
    public int CompareTo(Book other)
    {
        return this.year.CompareTo(other.year);
    }
}

// Класс "Домашняя библиотека"
class HomeLibrary
{
    // Массив книг
    private Book[] books;

    // Конструктор библиотеки
    public HomeLibrary()
    {
        books = new Book[0];
    }

    // Добавление книги в библиотеку
    public void AddBook(Book book)
    {
        Array.Resize(ref books, books.Length + 1);
        books[books.Length - 1] = book;
    }

    // Удаление книги из библиотеки
    public void RemoveBook(int index)
    {
        for (int i = index; i < books.Length - 1; i++)
        {
            books[i] = books[i + 1];
        }
        Array.Resize(ref books, books.Length - 1);
    }

    // Поиск книги по году издания
    public Book[] FindBooksByYear(int year)
    {
        Book[] result = new Book[0];
        foreach (Book book in books)
        {
            if (book.year == year)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = book;
            }
        }
        return result;
    }

    // Получение книги по номеру
    public Book GetBook(int index)
    {
        return books[index];
    }
}

// Точка входа в программу
class Program
{
    static void Main(string[] args)
    {
        // Создание библиотеки и добавление книг
        HomeLibrary library = new HomeLibrary();
        library.AddBook(new Book("Жизнь в коде", "Варченя", 1866));
        library.AddBook(new Book("Мастер и Маргарита", "М.А. Булгаков", 1966));
        library.AddBook(new Book("11/22/63", "Стивен Кинг", 2011));
        library.AddBook(new Book("Унесенные ветром", "М.Митчелл", 1936));

        // Поиск книг по году издания
        Console.Write("Введите год издания книги, которые хотите найти: ");
        int year = int.Parse(Console.ReadLine());
        Book[] booksByYear = library.FindBooksByYear(year);
        if (booksByYear.Length == 0)
        {
            Console.WriteLine("Книги, изданные в {0} году, не найдены.", year);
        }
        else
        {
            Console.WriteLine("Книги, изданные в {0} году:", year);
            foreach (Book book in booksByYear)
            {
                Console.WriteLine(book.title + " от " + book.author);
            }
        }

        // Удаление книги из библиотеки
        Console.Write("Введите номер книги, которую хотите удалить: ");
        int bookIndex = int.Parse(Console.ReadLine());
        library.RemoveBook(bookIndex);

        // Получение книги по номеру
        Console.Write("Введите номер книги, которую хотите получить: ");
        int bookNumber = int.Parse(Console.ReadLine());
        Book bookByNumber = library.GetBook(bookNumber);
        Console.WriteLine("Книга под номером {0}: {1}", bookNumber, bookByNumber.title);
    }
}
