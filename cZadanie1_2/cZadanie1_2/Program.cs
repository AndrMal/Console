using System;

namespace cZadanie1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                int a = int.Parse(Console.ReadLine());
                if (a.ToString().Length != 2)
                {
                    throw new Exception();
                }
                if (((a/10) + (a%10)) % 2 == 0)
                {
                    Console.WriteLine("Сумма четная");
                }
                else
                {
                    Console.WriteLine("Сумма нечетная");
                }
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы должны ввести число!");
            }
            catch (Exception)
            {
                Console.WriteLine("Вы должны ввести двузначное число!");
            }
        }
    }
}
