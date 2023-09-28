using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index < 4) {
                int num = int.Parse(Console.ReadLine());
                if (num == 4) {
                    Console.WriteLine("Что ж...верно, я человек - слово, можешь забирать своего отца");
                    break;
                } else if (index == 3) {
                    Console.WriteLine("Ты не угадал...");
                    break;
                } else {
                    Console.WriteLine($"Не угадал, попытка номер {index + 1}");
                }
                index++;
            }

            Console.ReadKey();
        }
    }
}
