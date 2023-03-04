using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class a4
{
    public static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int P = 2 * (a + b);
        int S = a * b;
        double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine($"P= {P}, S= {S}, d={d}."); //вывeсти посмотреть
    }
}