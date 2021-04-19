using System;

namespace Fibonachi_Recur
{
    class Program
    {
        static void Main(string[] args)///число фибоначи методом рекурсии
        {
            Run();
        }
        static void Run()
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write($"{FibonachiRecurtion(i)} | ");
                else
                    Console.WriteLine($"{FibonachiRecurtion(i)} | ");
            }
            Run();// для удобства 
        }
        static int FibonachiRecurtion(int f)
        {
            if (f == 0) return 0;// задаем первое значение в ручную
            if (f == 1) return 1;// вторую тоже
            return FibonachiRecurtion(f - 1) + FibonachiRecurtion(f - 2);//возвращаем метод  


        }
    }
}
