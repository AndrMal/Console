using System;

namespace cZadanie5
{
    class Program
    {
        static double f(double x)
        {
            if ((x-1) == 0 || (1-4*x) == 0)
            {
                throw new DivideByZeroException();
            }
            return (1 / (x - 1)) + (2 / (1 - 4 * x));
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h: ");
                double h = Double.Parse(Console.ReadLine());
                for (double x = a; x<=b; x+=h)
                {
                    Console.WriteLine("f({0}) = {1}", x, f(x));
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
            catch(System.DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
        }
    }
}
