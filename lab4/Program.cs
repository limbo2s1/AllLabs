using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number1();

            Console.WriteLine();
            Number2();

            Console.WriteLine();
            Number3();

            Console.ReadKey();
        }

        static void Number1()
        {
            Console.WriteLine("== Задание 1 ==");
            int[] mass = new int[30];
            Random random = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 100);
                Console.Write("\t" + mass[i]);
            }

        }


        static void Number2()
        {
            Console.WriteLine("== Задание 2 ==");
            string str = "awd 23 f 4 rg3 3";
            string[] strArr = str.Split(' ');
            foreach (string el in strArr)
            {
                Console.WriteLine(el);
            }
        }

        static void Number3()
        {
            Console.WriteLine("== Задание 3 ==");
            int temp = 0;
            int[] mass = new int[] { 1, 3, 41, 2, 45, 6, 12, 43 };


            for (int i = 0; i < mass.Length; i++)
            {

                for (int j = 0; j < mass.Length - 1 - i; j++)
                {

                    if (mass[j] > mass[j + 1])
                    {
                        temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
