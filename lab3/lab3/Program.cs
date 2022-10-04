using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Номер 1 ==");
            Number1();
            Console.WriteLine("== Номер 2 ==");
            Number2();
            Console.ReadKey();
        }
        static void Number1()
        {
            Console.WriteLine("Счётчик:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 18 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("цикл с постусловием:");
            int a = 0;
            do
            {
                a++;

                if (a % 18 == 0)
                {
                    Console.WriteLine(a);
                }

            }
            while (a <= 100);

            Console.WriteLine("цикл с предусловием:");

            int b = 0;
            while (b < 100)
            {
                b++;
                if (b % 18 == 0)
                {
                    Console.WriteLine(b);
                }

            }
        }
        static void Number2()
        {
            int с = 0;
            for (int i = 0; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    с += i;

                }
            }
            Console.WriteLine("Сумма нечетных чисел: " + с);
        }
    }
}
