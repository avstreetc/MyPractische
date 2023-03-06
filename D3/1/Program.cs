using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1lab4a1
{
    class Claass
    {
        static void Main()
        {
            // Вычисление Z по методу функции
            int a = 123;
            int b = 426;
            //int c = 739;

            int z = f(a) + f(b); //- f(c);

            // 2+2-3 = 1
            Console.WriteLine("Результат z = " + z);
        }

        static int f(int x)
        {
            // Метод f(x), %100 остаток N(последние две цифры), первое число двухзначного я N  
            return x % 100 / 10;
        }
    }
}