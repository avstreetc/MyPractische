using System;

class Table
{
    // закрытые поля класса
    private string name; // название стола
    private double area; // S площадь стола в см

    // конструктор с параметрами
    public Table(string name, double area)
    {
        this.name = name;
        this.area = area;
    }

    // методы доступа к закрытым полям
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Area
    {
        get { return area; }
        set { area = value; }
    }

    // метод, вычисляющий стоимость стола
    public double GetCost(double k)
    {
        return (area *  2 / 3 + k);
    }
}

class WritingTable : Table
{
    // дополнительные поля класса
    private string material; // используемый материал
    private double decorationCost; // стоимость отделки

    // конструктор с параметрами
    public WritingTable(string name, double area, string material, double decorationCost)
        : base(name, area) // вызов конструктора базового класса
    {
        this.material = material;
        this.decorationCost = decorationCost;
    }

    // методы доступа к дополнительным полям
    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public double DecorationCost
    {
        get { return decorationCost; }
        set { decorationCost = value; }
    }

    // переопределенный метод, вычисляющий полную стоимость стола с учетом отделки
    public new double GetCost(double k)
    {
        // вызов метода GetCost() базового класса и добавление стоимости отделки и наценки
        return base.GetCost(k) + decorationCost + 0.1 * base.GetCost(k);
    }
}

class a1
{
    static void Main(string[] args)
    {
        // создание объектов базового и производного классов
        // ввод названия и площади стола с клавиатуры
        Console.Write("Введите название стола:");
        string tableName = Console.ReadLine();

        Console.Write("Введите площадь стола:");
        double tableArea = double.Parse(Console.ReadLine());

        // создание объекта класса Table с введенными значениями
        Table table = new Table(tableName, tableArea);
        //Table table = new Table("Деревянный стол", 1000);
        
        WritingTable writingTable = new WritingTable("Письменный стол", 800, "Дуб", 200);

        // вывод информации о базовом классе
        //Console.WriteLine("Название стола: {0}", table.Name);
        //Console.WriteLine("Площадь стола: {0}", table.Area);
        Console.WriteLine("Стоимость стола: {0}", table.GetCost(10));

        Console.WriteLine();

        // вывод информации о производном классе
        Console.WriteLine("Название стола: {0}", writingTable.Name);
        Console.WriteLine("Площадь стола: {0}", writingTable.Area);
        Console.WriteLine("Материал стола: {0}", writingTable.Material);
        Console.WriteLine("Стоимость отделки: {0}", writingTable.DecorationCost);
        Console.WriteLine("Стоимость письменного стола: {0}", writingTable.GetCost(10));
    }
}