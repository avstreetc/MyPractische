interface Ix
{
    void IxF0(int w);
    void IxF1();
}

interface Iy
{
    void F0(int w);
    void F1();
}

interface Iz
{
    void F0(int w);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    public int w;

    // Неявная реализация методов Iy
    public void F0(int w)
    {
        Console.WriteLine("Результат неявной реализации метода F0 интерфейса Iy: " + w * 3);
    }

    public void F1()
    {
        Console.WriteLine("Метод F1 интерфейса Iy выполнен");
    }

    // Явная реализация методов Iz
    void Iz.F0(int w)
    {
        Console.WriteLine("Результат явной реализации метода F0 интерфейса Iz: " + (6 + w));
    }

    void Iz.F1()
    {
        Console.WriteLine("Метод F1 интерфейса Iz выполнен");
    }

    public void IxF0(int w)
    {
        Console.WriteLine("Результат метода IxF0 интерфейса Ix: " + (7 * w - 4));
    }

    public void IxF1()
    {
        Console.WriteLine("Метод IxF1 интерфейса Ix выполнен");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass test = new TestClass();
        test.w = 5;

        // Вызов методов интерфейса Iy
        ((Iy)test).F0(test.w);
        ((Iy)test).F1();

        // Вызов методов интерфейса Iz
        ((Iz)test).F0(test.w);
        ((Iz)test).F1();

        // Вызов методов интерфейса Ix
        test.IxF0(test.w);
        test.IxF1();

        // Вызов методов через интерфейсную ссылку параметр
        Ix ix = test;
        ix.IxF0(test.w);
        ix.IxF1();

        Iy iy = test;
        iy.F0(test.w);
        iy.F1();

        Iz iz = test;
        iz.F0(test.w);
        iz.F1();
    }
}