class a11
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            if (x == 1)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен 0");
            }

            double y = Math.Pow(Math.Tan(x), 2) + (1 / (x - 1));

            Console.WriteLine("Значение выражения b. y = {0}", y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка ввода: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}