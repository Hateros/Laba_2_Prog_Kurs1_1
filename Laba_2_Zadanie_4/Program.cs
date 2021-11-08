using System;
using System.Linq;

namespace Laba_2_Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, d, N, f;
            double q, x, sum;
            Console.WriteLine("Введите количество слагаемых:");
            q = double.Parse(Console.ReadLine());
            while (q <= 0)
            {
                Console.WriteLine("Введите корректное количество слагаемых:");
                q = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());
            i = 1;
            sum = 1;
            d = 2;
            N = 2;
            while (i <= q)
            {
                // + using System.Linq; LINQ - это интегрированный язык запросов
                //Операция Range генерирует последовательность целых чисел. 
                //Операция Aggregate выполняет указанную пользователем функцию на каждом элементе входной последовательности,
                //передавая значение, возвращенное этой функцией для предыдущего элемента, и возвращая ее значение для последнего элемента.
                f = Enumerable.Range(1, N).Aggregate((p, g) => p * g);
                sum -= (Math.Pow(x, d) / f);
                N += 2;
                d += 2;
                f = Enumerable.Range(1, N).Aggregate((p, g) => p * g);
                sum += (Math.Pow(x, d) / (f));
                N += 2;
                d += 2;
                i++;
                if (q > (Math.Pow(x, d) / (f)) || q < (-1 * (Math.Pow(x, d) / (f)))) 
                //если значение по модулю очередного слагаемого окажется меньше q,
                //то расчет суммы нужно остановить, на экран надо вывести также количество учтенных слагаемых
                {
                    Console.WriteLine("Значение слагаемого по модулю меньше количества слагаемых \nКоличество учтенных слагаемых: {0}", i - 1);
                    Console.ReadKey();
                    return;
                }

            }
            Console.WriteLine("cos(x)={0}", sum); 
        }
    }
}
