using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            if (symbol == "+") {
                Console.WriteLine(firstNum + secondNum);
            } else if (symbol == "-") {
                Console.WriteLine(firstNum - secondNum);
            } else if (symbol == "*") { 
                Console.WriteLine(firstNum * secondNum);
            } else if (symbol == "/") {
                if (secondNum == 0) {
                    Console.WriteLine("Ошибка");
                } else {
                    Console.WriteLine(firstNum / (double)secondNum);
                }
            } else if (symbol == "%") {
                Console.WriteLine(firstNum * 0.01 * secondNum);
            }

            Console.ReadKey();
        }
    }
}
