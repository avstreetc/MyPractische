using System;

class a2
{
    static void Main(string[] args)
    {
        // Создаем лямбда-операторы для выполнения арифметических действий
        Func<double, double, double> Add = (x, y) => x + y;
        Func<double, double, double> Sub = (x, y) => x - y;
        Func<double, double, double> Mul = (x, y) => x * y;
        Func<double, double, double> Div = (x, y) => (y != 0) ? (x / y) : double.NaN;

        Console.WriteLine("Введите Первое число: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите Второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите арифметическое действие (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        // Выполняем выбранное арифметическое действие с помощью соответствующего лямбда-оператора
        switch (operation)
        {
            case '+':
                Console.WriteLine("Результат сложения: {0}", Add(num1, num2));
                break;
            case '-':
                Console.WriteLine("Результат вычитания: {0}", Sub(num1, num2));
                break;
            case '*':
                Console.WriteLine("Результат умножения: {0}", Mul(num1, num2));
                break;
            case '/':
                Console.WriteLine("Результат деления: {0}", Div(num1, num2));
                break;
            default:
                Console.WriteLine("Некорректный оператор");
                break;
        }
    }
}
