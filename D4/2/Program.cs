using System;

class a2
{
    static void Main()
    {
        try
        {
            Console.Write("Введите вещественное число x: ");
            double x = double.Parse(Console.ReadLine());

            double f;

            if (x<-1)
            {
                throw new Exception("x должно быть больше или равно -1.");
            }
            else if (x == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }
            else if (x >= 1)
            {
                f = 5 * x + 2;
            }
            else
            {
                f = Math.Cos(x) / x;
            }
            //else
            //{
            //    throw new Exception("x должно быть меньше 1.");
            //}

            Console.WriteLine("f = " + f);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}