using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            Console.WriteLine("Бон Жорно, как вас двоих зовут?");
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine($"Теперь я {secondName} {firstName}! Чао!");
            Console.ReadKey();
        }
    }
}
