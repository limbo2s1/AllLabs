using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("Первое задание:");
            double first = (Math.Pow(2, 2) - Math.Pow(3, 3));
            double second = (Math.Sqrt(Math.Pow(3, 4) - Math.Pow(2, 4)));
            double third = first / second;
            double fourth = Math.Abs(Math.Pow(3, 5) - Math.Pow(15, 2.5));
            double fifth = third + fourth;
            double sixth = Math.Sqrt(fifth);
            Console.WriteLine("Ответ: " + sixth);
        }
        static void Task2()
        {
            Console.WriteLine("Второе задание:");
            Random rnd = new Random();
            int a = rnd.Next(-100, 100);
            Console.WriteLine("a=" + a);
            int b = rnd.Next(-100, 100);
            Console.WriteLine("b=" + b);
            double c = (Math.Pow(a, 2) + Math.Cbrt(b)) / (a + b);
            Console.WriteLine("c=" + c);
        }
        static void Task3()
        {
            Console.WriteLine("Третье задание:");
            double a = 5.93576;
            int b = (int)a;
            Console.WriteLine("b=" + b);
            double c = Convert.ToInt32(Math.Round(a));
            Console.WriteLine("c=" + c);
            double d = (Math.Floor(a));
            Console.WriteLine("d=" + d);
            double e = Math.Round(a, 1);
            Console.WriteLine("e=" + e);
            int f = 5;
            int g = f++;
            Console.WriteLine("g=" + g);
            int F = 5;
            int G = ++F;
            Console.WriteLine("G=" + G);
        }
        static void Task4()
        {
            Console.WriteLine("Четвертое задание:");
            Random rnd = new Random();
            double chislo = rnd.Next(-100, 100) + rnd.NextDouble();
            chislo = Math.Round(chislo, 3);
            Console.WriteLine("Рандомное десятичное число от -100 до 100=" + chislo);
        }
    }
}

