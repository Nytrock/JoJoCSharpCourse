using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();

            switch (phrase) {
                case "Марлоно Брандо":
                    Console.WriteLine("Ты стал чуть ближе к раю, тебе будет дарована божественная сила...");
                    break;
                case "Бравл Старс":
                    Console.WriteLine("Ты никогда не попадешь на небеса!");
                    break;
                default: 
                    Console.WriteLine("Неверная фраза");
                    break;
            }

            Console.ReadKey();
        }
    }
}
