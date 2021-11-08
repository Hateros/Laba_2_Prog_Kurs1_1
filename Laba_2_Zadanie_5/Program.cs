using System;

namespace Laba_2_Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double x, y, z, sum;
            Console.WriteLine("Введите натуральное число:");
            N = int.Parse(Console.ReadLine());
            while (N < 0)
            {
                Console.WriteLine("Введите другое число");
                N = int.Parse(Console.ReadLine());
            }
            i = 0;
            for (x = 1; x < N; x++)
            {
                for (y = 1; y < N; y++)
                {
                    for (z = 1; z < N; z++)
                    {
                        sum = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                        if (sum == N)
                        {
                            Console.WriteLine("{0}^3 + {1}^3 + {2}^3 = {3}", x, y, z, N);
                            i++;
                        }
                    }
                }
            }
            if (i == 0)
            {
                Console.WriteLine("No such combinations!");
                return;
            }

        }
    }
}
