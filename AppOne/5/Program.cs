using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a5
{
    class Claass
    {
        static void Main()
        {
            Console.WriteLine("Вычисление стоимости покупки. ");
            Console.Write("Цена одного килограмма яблок (руб.) - ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Вес яблок (кг) - ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double cost = price * weight;

            Console.WriteLine($"Стоимость покупки: {cost:F2}");
        }
    }
}