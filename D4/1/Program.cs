using System;

class a1
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            if (x == -2)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен 0");
            }

            double y = 1 - (4 / (4 * x + 8));
            //double y2 = Math.Tan(x) + (1 / (x - 1));

            Console.WriteLine("Значение выражения a. y = {0}", y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка ввода: " + ex.Message);
        }
        catch (Exception ex) // фигню обрабатывает, исключительные ситуации
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}