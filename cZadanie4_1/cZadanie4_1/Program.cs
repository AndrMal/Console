using System;

namespace cZadanie4_1
{
    class Program
    {
        static double f(double N)
        {
            return N / sqr(N, 1);
        }
        static double sqr(double N, double i)
        {
            if (i > N)
            {
                return 0;
            }
            else
            {
                return Math.Sqrt(i + sqr(N, i + 1));
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите N: ");
                double N = Double.Parse(Console.ReadLine());
                if (N < 0)
                {
                    throw new Exception("N должно быть больше нуля!");
                }
                Console.WriteLine("Результат: {0}", f(N));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
