using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.dll;

class a3
{
    public static void Main()
    {
        double x = 6.4; // берём переменную х, по задaнию 6,4
        double e = Math.E;

        double y = (Math.Pow(e, x) / Math.Cos(Math.Sqrt(x - 1)))
            + ((2 * Math.Atan(Math.Pow(x, 2))) / (1 - x));
        Console.WriteLine(y); //вывести посмотреть 
    }
}