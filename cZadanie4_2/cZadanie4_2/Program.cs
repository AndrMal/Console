using System;

namespace cZadanie4_2
{
    class Program
    {
        static string f(int N)
        {
            if (N==0)
            {
                return "0";
            }
            else if (N==1)
            {
                return "1";
            }
            else
            {
                if (N % 2 == 0)
                {
                    return f(N / 2) + "0";
                }
                else
                {
                    return f(N / 2) + "1";
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число: ");
                int N = int.Parse(Console.ReadLine());                
                Console.WriteLine("Ответ: {0}",f(N));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
    }
}
