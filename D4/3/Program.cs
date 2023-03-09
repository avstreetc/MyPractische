using System;

class a3
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введите {i + 1}-е число: ");
            string input = Console.ReadLine();
            try
            {
                // введенную строку в целое число
                int number = int.Parse(input);

                int count, sum;
                DigitCountSum(number, out count, out sum);
                Console.WriteLine($"Кол-во цифр: {count}, Их сумма: {sum}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    static void DigitCountSum(int k, out int c, out int s)
    {
        if (k <= 0)
        {
            throw new ArgumentException("Число должно быть больше 0");
        }

        c = 0;
        s = 0;
        while (k > 0)
        {
            int digit = k % 10;
            c++;
            s += digit;
            k /= 10;
        }
    }
}