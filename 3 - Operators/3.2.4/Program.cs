using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0) {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Квадратное уравнение имеет 2 корня: {x1} и {x2}");
            } else if (d == 0) {
                double x = -b / (2 * a);
                Console.WriteLine($"Квадратное уравнение имеет 1 корень: {x}");
            } else {
                Console.WriteLine("Нет корней");
            }

            Console.ReadKey();
        }
    }
}
