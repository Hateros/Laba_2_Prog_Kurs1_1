using System;

namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, Discr, x1, x2, z1, z2, y1, y2, y3;
            Console.WriteLine("Я помогу решить тебе квадратное уравнение вида ax^2+bx+c=0 \nВведи значение a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи значение b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введи значение c:");
            c = double.Parse(Console.ReadLine());
            Discr = (b * b) - (4 * a * c);
            
            if (Discr > 0)
            {
                x1 = (-b + Math.Sqrt(Discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(Discr)) / (2 * a);
                Console.WriteLine("x1={0} \nx2={1}", x1, x2);
            }
            if (Discr == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Дискриминант равен нулю, уравнение имеет 1 корень: \nx={0}", x1);
            }
            if (Discr < 0)
            {
                z1 = Math.Sqrt(Discr * (-1));
                z2 = Math.Sqrt(Discr * (-1));
                y1 = -b / 2 * a;
                y2 = z1 / 2 * a;
                y3 = -z2 / 2 * a;
                Console.WriteLine("Дискриминант меньше нуля => \nx1={0}+{1}*i \nx2={0}+({2})*i", y1, y2, y3);
            }
        }
    }
}
