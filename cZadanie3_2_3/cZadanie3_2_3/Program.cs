using System;

namespace cZadanie3_2_3
{
    class Program
    {
        public static void f(double a, double b, double h)
        {
            for (double x = a; x <= b; x += h)
            {
                if (x < 1)
                {
                    Console.WriteLine("f({0}) = {1}", x, (x * x - 1) * (x * x - 1));
                }
                else if (x > 1)
                {
                    Console.WriteLine("f({0}) = {1}", x, 1 / (1 + x * x));
                }
                else
                {
                    Console.WriteLine("f(1) = 0");
                }
            }
        }
        public static void f(double x, out double y)
        {
            if (x < 1)
            {
                y = (x * x - 1) * (x * x - 1);
            }
            else if (x > 1)
            {
                y = 1 / (1 + x * x);
            }
            else
            {
                y = 0;
            }
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
                f(a, b, h);

                Console.WriteLine("Задание 3");
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    Console.Write("{0} ", y);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено не число!");
            }
        }
    }
}
