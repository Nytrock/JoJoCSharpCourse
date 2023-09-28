using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int firstNum = num / 100;
            int secondNum = num % 100 / 10;
            int thirdNum = num % 10;

            if (firstNum % 2 == 0 || secondNum % 2 == 0 ||  thirdNum % 2 == 0) {
                Console.WriteLine("Видимо, между нами нет гравитации...");
            } else {
                Console.WriteLine("Тебе уготована дорога прямо в рай!");
            }

            Console.ReadKey();
        }
    }
}
