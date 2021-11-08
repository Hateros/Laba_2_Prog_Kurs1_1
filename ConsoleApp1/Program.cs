using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 100");
            int Year = int.Parse(Console.ReadLine());
            while (Year > 100 || Year < 1)
            {
                Console.WriteLine("Введите другое число");
                Year = int.Parse(Console.ReadLine());
            }
            if (Year > 4 && Year < 21)
            {
                Console.WriteLine("{0} лет", Year);
            }
            else if (Year % 10 == 1)
            {
                Console.WriteLine("{0} год", Year);
            }
            else if (Year % 10 > 1 && Year % 10 < 5)
            {
                Console.WriteLine("{0} года", Year);
            }
            else if (Year % 10 == 0 || Year % 10 > 4 && Year % 10 < 10)
            {
                Console.WriteLine("{0} лет", Year);
            }

        }
    }
}
