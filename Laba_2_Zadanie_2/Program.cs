using System;

namespace Laba_2_Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kolv, i;
            double sum, slg, rez, d, drob;
            Console.WriteLine("Введите количество слагаемых:");
            kolv = int.Parse(Console.ReadLine());
            rez = 4;
            while (kolv < 1)
            {
                Console.WriteLine("Что-то не хватает слагаемых, введите другое количество:");
                kolv = int.Parse(Console.ReadLine());
            }
            if (kolv == 1)
            {
                Console.WriteLine("Число ПИ по формуле с количеством слагаемых 1 равно: \n" + rez);
            }
            sum = 1;
            i = 1;
            d = 3;
            while (i <= kolv)
            {
                sum = sum - (1 / d) + (1 / (d + 2));
                d += 4;
                i++;
            }
            rez = sum * 4;
            Console.WriteLine("Пи по формуле с количеством слагаемых {0} равняется: \n{1}", kolv, rez);
        }
    }
}
