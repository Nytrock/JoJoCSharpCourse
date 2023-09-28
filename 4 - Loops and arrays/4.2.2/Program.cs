using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool simple = true;

            for (int i = 2; i < Math.Sqrt(num); i++) {
                if (num % i == 0) simple = false;
            }

            if (simple && num.ToString().Length == 3)
                Console.WriteLine("Трехзначное простое число - вход разрешен");
            else
                Console.WriteLine("Вход запрещен");

            Console.ReadKey();
        }
    }
}
