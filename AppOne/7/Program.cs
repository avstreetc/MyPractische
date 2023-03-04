using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7
{
    class Claass
    {
        static void Main()
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double z1 = Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4))
                / ((Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2));

            double z2 = 1 /
                Math.Sqrt(b + 2);

            Console.WriteLine("Результат z1= {0}, и z2= {1}", z1, z2);
        }
    }
}