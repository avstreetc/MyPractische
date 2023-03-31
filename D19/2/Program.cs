namespace z3
{
    class Claass
    {
        /// <summary> Метод для реализации кода </summary>
        static void Main()
        {
            /// <summary> Объявление переменных </summary>
            int a, b, c;
            
           
            Console.WriteLine("Введите Первое A число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Второе B число: ");
            b = int.Parse(Console.ReadLine());

            /// <summary> Проверка для реализации:
            /// Приравнивание, если не ровны
            /// Иначе равны нулю
            /// </summary>
            if (a != b)
            {
                int sum = a + b;
                a = sum;
                b = sum;
                Console.WriteLine($"Ох, они не равны, а они  a={a} и b={b}");
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"Они равны, и они стали a={a} и b={b}");
            }
        }
    }
}