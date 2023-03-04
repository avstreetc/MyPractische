using System;

class A
{
    // класс А с целочисленными полями а и b
    int a;
    int b;

    // Внутри класса реализовать конструктор для инициализации a и b.
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    // Метод вычисления значения выражения ((-b+(1/a))/3).
    public double ExpressionValue()
    {
        double result = (-b + (1.0 / a)) / 3.0;
        return result;
    }

    // Метод возведения в куб суммы a и b.
    public int SumCubed()
    {
        int sum = a + b;
        int cubedSum = sum * sum * sum;
        return cubedSum;
    }
}

class a1
{
    static void Main(string[] args)
    {
        // Создать объект класса и продемонстрировать работу со всеми элементами класса.
        A obj = new A(2, 3);

        // вызываем эти приколдесы
        double exprValue = obj.ExpressionValue();
        Console.WriteLine($"Значение выражения ((-b+(1/a))/3) равно {exprValue}.");

        int cubedSum = obj.SumCubed();
        Console.WriteLine($"Куб суммы a и b равен {cubedSum}.");
    }
}