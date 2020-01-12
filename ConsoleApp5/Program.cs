using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в метрах: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число полных километров: {num / 1000}");
            Console.ReadKey();
        }
    }
}
