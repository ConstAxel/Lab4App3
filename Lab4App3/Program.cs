using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4App3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ka = 0; //квадратов по А
            int kb = 0; //квадратов по Б
            int k = 0; // Общее кол-во квадратов
            Console.Write("Введите число А> 0:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число Б> 0:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число С> 0:");
            int c = Convert.ToInt32(Console.ReadLine());
            while (c <= a)
            {
                ka++;
                a = a - c;
            }
            while (c <= b)
            {
                kb++;
                b = b - c;

            }
            for (int i = 0; i < kb; i++)
            {
                k = k + ka;

            }
            Console.WriteLine($"Число квадратов:{k}");
            Console.ReadKey();
        }
    }
}
