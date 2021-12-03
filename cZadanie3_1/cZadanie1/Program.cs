using System;

namespace cZadanie1
{
    class Program
    {
        static double f(double x)
        {
            if (x<0)
            {
                return 0;
            }
            else
            {
                return x / 2;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: {0}", f(x));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено не число!");
            }            
        }
    }
}
