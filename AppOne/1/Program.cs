using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1  //запрашивает с клавиатуры три вещественных числа,
              //и выводит на следующее сообщение. Пр часть задан.1
{
    class One
    {
        public static void Main()
        {
            double a, b, c; // объявление переменны
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());  // ввод значения с клавиатур

            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());

            // выводим сообщение с подставленными значениями a, b и c
            Console.WriteLine($"({a:F2} + {b:F2}) + {c:F2} = {a:F2} + ({b:F2} + {c:F2})");
        }
    }
}