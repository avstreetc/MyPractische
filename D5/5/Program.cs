using System;

class a3
{
    static double CalculateFunction(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            // n=1. (1+5)!=6!=1*2*3*4*5*6=720. 1/720= 0.138889
            double factorial = 1; //значение факториала
            int fac = (n + 5); //кол-во циклов
            for (int i = 2; i <= fac; i++) 
            {
                factorial = factorial * i;
            }
            double res = 1/factorial;
            return res;
            //(1 / ((n + 5) * CalculateFunction(n - 1)));
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
        double result = CalculateFunction(n);
        
        Console.WriteLine("f({0}) = {1}", n, result);
    }
}
