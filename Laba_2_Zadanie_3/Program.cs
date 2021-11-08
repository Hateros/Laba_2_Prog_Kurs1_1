using System;

namespace Laba_2_Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f0 = 0;
            int i = 0;
            int f1 = 1;
            while (f1 < 10000)
            {
                int f = f0 + f1;
                f0 = f1;
                f1 = f;
                if ((f / 1000) >= 1 && (f / 1000) < 10)
                {
                    i++;
                }

            }
            Console.WriteLine("Количество четырехзначных чисел в ряде Фибоначчи: {0}", i);

        }
    }
}
