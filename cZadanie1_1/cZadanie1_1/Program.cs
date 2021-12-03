using System;

namespace cZadanie1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите V: ");
                double V = double.Parse(Console.ReadLine());
                Console.WriteLine("а = {0}", Math.Pow(V, 1 / 3.0));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Нужно ввести число!");
            }
        }
    }
}
