class a2
{
    static void Main(string[] args)
    {
        string filePath = "MyFale.txt";

        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        List<int> numbersInRange = new List<int>();
        List<int> numbersLessThanA = new List<int>();
        List<int> numbersGreaterThanB = new List<int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                int number = int.Parse(reader.ReadLine());

                if (number >= a && number <= b)
                {
                    numbersInRange.Add(number);
                }
                else if (number < a)
                {
                    numbersLessThanA.Add(number);
                }
                else if (number > b)
                {
                    numbersGreaterThanB.Add(number);
                }
            }
        }

        Console.WriteLine($"Числа в интервале [{a}, {b}]:");
        foreach (int number in numbersInRange)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Числа меньше {a}:");
        foreach (int number in numbersLessThanA)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"Числа больше {b}:");
        foreach (int number in numbersGreaterThanB)
        {
            Console.WriteLine(number);
        }
    }
}
