using System;

class a4
{
    static void Main(string[] args)
    {
        for (int inch = 2; inch <= 24; inch += 2)
        {
            double cm = inch * 2.54;
            Console.WriteLine($"{inch} дюймов = {cm:F2} см");
        }
    }
}