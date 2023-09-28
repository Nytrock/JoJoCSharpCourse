using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            double sTriangle = (Math.Pow(side, 2) * Math.Sqrt(3)) / 4;
            double sHex = (3 * Math.Pow(side, 2) * Math.Sqrt(3)) / 2;

            Console.WriteLine("Площадь равностороннего треугольника: " + sTriangle);
            Console.WriteLine("Площадь правильного шестиугольника: " + sHex);

            Console.ReadKey();
        }
    }
}
