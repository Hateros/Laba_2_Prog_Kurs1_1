using System;

namespace Laba_2_Zadanie_2_Indiv_Variant_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, N;
            Console.WriteLine("Введите натуральное число от 1 до 10000:");
            N = int.Parse(Console.ReadLine());
            while (N > 10000 || N < 1)
            {
                Console.WriteLine("Введите другое число, в пределах допустимого:");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Нечетные делители числа:");
            for (x = 1; x <= N; x += 2)
            {
               Console.Write("{0} ", x);
            }
        }
    }
}
