using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Claass
    {
        static void Main()
        {
            //double x;
            //Console.WriteLine("Введите X: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //double answer = f(x);
            //Console.WriteLine($"Ответ: {answer}");

            double x; double a; double b; double h;

            Console.Write("Введите a=: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b=: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите h=: ");
            h = double.Parse(Console.ReadLine());

            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                Console.WriteLine($"f({i})={y}");
            }
        }

        // перегрузить метода при 
        // static double f(double x, double y)
        static double f(double x)
        {
            double con = ((Math.Pow(x, 2)) + 2 * x + 1);
            //Console.Write(con);
            double y = 0;

            if (con < 2)
                y = Math.Pow(x, 2);
            else if (2 <= con && con < 3)
                y = 1 / ((Math.Pow(x, 2)) - 1);
            else y = 0;
            return y;
        }

        static void f(double x, out double y)
        {
            double con = ((Math.Pow(x, 2)) + 2 * x + 1);
            //Console.Write("вариант работы сон" + con);
            y = 0;

            if (con < 2)
            {
                y = Math.Pow(x, 2);
            }
            if (2 <= con && con < 3)
            {
                y = 1 / ((Math.Pow(x, 2)) - 1);
            }
            else if (con >= 3)
            {
                y = 0;
            }
        }


    }
}