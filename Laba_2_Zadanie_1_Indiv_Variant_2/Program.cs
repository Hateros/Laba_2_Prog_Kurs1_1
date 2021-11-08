using System;

namespace Laba_2_Zadanie_1_Indiv_Variant_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое вещественное число:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе вещественное число:");
            double second = double.Parse(Console.ReadLine());
            if (first < 0 || second < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (first < second)
            {
                first = Math.Sqrt(first);
                Console.WriteLine("Квадратный корень меньшего числа={0}", first);
            }
            if (first > second)
            {
                second = Math.Sqrt(second);
                Console.WriteLine("Квадратный корень меньшего числа={0}", second);
            }
            if (first == second)
            {
                first = Math.Sqrt(first);
                Console.WriteLine("Числа равны \nКвадратный корень числа={0}", first);
            }
        }
    }
}
