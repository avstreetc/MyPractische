namespace z1
{
    /// <summary>
    /// Класс для нахождения двух одинаковых чисел среди трёх
    /// </summary>
    class Claass
    {
        /// <summary>
        /// Метод для ввода трёх чисел пользователем и проверки соответствия
        /// </summary>
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите Первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Третье число: ");
            c = int.Parse(Console.ReadLine());

            /// <summary> Проверка на соответствии пары чисел</summary>
            if (a == b || a == c || b == c)
                Console.WriteLine("True! А мы здесь нашли две одинаковые цифры!");
            else
                Console.WriteLine("False! Эх, мы не нашли два одинаковых числа ");
        }
    }
}