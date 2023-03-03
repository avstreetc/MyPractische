using System;

class a4
{
    static void Main(string[] args)
    {
        int inch = 2;
        while (inch <= 24)
        {
            double cm = inch * 2.54;
            Console.WriteLine($"{inch} дюймов = {cm:F2} см");
            inch += 2;
        }
    }
}