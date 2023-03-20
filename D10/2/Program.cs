using System;

// Базовый класс А
class A
{
    protected int a = 10; // поле a со значением 10
    protected int b = 20; // поле b со значением 20

    public int C // свойство C - результат выражения a + b
    {
        get
        {
            return a + b;
        }
    }
}

// Класс В, наследник класса А
class B : A
{
    private int d = 30; // поле d со значением 30

    public int D // свойство D - результат выражения (A+B)=C + d
    {
        get
        {
            int result = C + d;
            if (result > 100) // если результат больше 100, вернуть 100
            {
                return 100;
            }
            else // иначе вернуть результат
            {
                return result;
            }
        }
    }

    // Конструктор, наследуемый от базового класса А
    public B() : base()
    {

    }

    // Собственный конструктор
    public B(int a, int b, int d)
    {
        this.a = a;
        this.b = b;
        this.d = d;
    }

    // Метод для изменения значения поля d
    public void SetD(int newD)
    {
        d = newD;
    }

    // Метод для вывода значения свойства C и D на экран
    public void PrintCD()
    {
        Console.WriteLine("Значение свойства C класса А: " + C);
        Console.WriteLine("Значение свойства D класса B: " + D);
    }
}

class a2
{
    static void Main(string[] args)
    {
        A aObj = new A();
        Console.WriteLine("Значение свойства C класса А: " + aObj.C);

        B bObj1 = new B();
        Console.WriteLine("Значение свойства D класса B (конструктор 1): " + bObj1.D);

        B bObj2 = new B(5, 15, 25);
        Console.WriteLine("Значение свойства D класса B (конструктор 2): " + bObj2.D);

        // уже изминили а и b, c = 5 + 15 = 20
        bObj2.SetD(50); // изменяем значение поля d у объекта bObj2 через метод
        bObj2.PrintCD(); // выводим значения свойств C и D на экран
    }
}
