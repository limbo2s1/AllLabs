using System;

namespace lab2
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
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите число в диапазоне [1,7]");
            string strNumber = Console.ReadLine();
            bool isNumber = int.TryParse(strNumber, out int number);
            if (number > 1 && number <= 7)
            {
                string day = "";
                switch (number)
                {
                    case 1:

                        day = "Понедельник";

                        break;

                    case 2:

                        day = "Вторник";

                        break;

                    case 3:

                        day = "Среда";

                        break;

                    case 4:

                        day = "Четверг";

                        break;

                    case 5:

                        day = "Пятница";

                        break;

                    case 6:

                        day = "Суббота";

                        break;

                    case 7:

                        day = "Воскресенье";

                        break;

                    default:

                        Console.WriteLine("Вы ввели число больше заданного диапазона");

                        break;
                }
                Console.WriteLine(day);
            }

            string ifDay = "";
            if (number > 1 && number <= 7)
            {
                if (number == 1)
                {
                    ifDay = "Понедельник";
                }

                if (number == 2)
                {
                    ifDay = "Вторник";
                }

                if (number == 3)
                {
                    ifDay = "Среда";
                }

                if (number == 4)
                {
                    ifDay = "Четверг";
                }

                if (number == 5)
                {
                    ifDay = "Пятница";
                }

                if (number == 6)
                {
                    ifDay = "Суббота";
                }

                if (number == 7)
                {
                    ifDay = "Воскресенье";
                }
            }
            Console.WriteLine(ifDay);
        }
        static void Task2()
        {
            Console.WriteLine("Задание 2");
            int fiznumber = int.Parse(Console.ReadLine());

            if (fiznumber % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else if (fiznumber % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

            if (fiznumber % 3 == 0 && fiznumber % 5 == 0)
            {
                Console.WriteLine("BuzzFizz");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Задание 3");
            double Value_1;
            double Value_2;
            string action;

            Console.Write("Введите число 1: ");
            Value_1 = double.Parse(Console.ReadLine());

            Console.Write("Введите число 2: ");
            Value_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию '+', '-', '*', '/' ");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(Value_1 + Value_2);
                    break;
                case "-":
                    Console.WriteLine(Value_1 - Value_2);
                    break;
                case "*":
                    Console.WriteLine(Value_1 * Value_2);
                    break;
                case "/":
                    Console.WriteLine(Value_1 / Value_2);
                    break;
                default:
                    {
                        Console.WriteLine("Неверное значение!");
                    }
                    break;
            }
        }
    }
}

