using AllLabsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    internal class Lab6 : ILabs
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary
        public void Demo()
        {
            Console.WriteLine("Если вы хотите посчитать число Фибоначчи нажмите 1, если же хотите посчитать факториал нажмите 2");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("// Вы выбрали посчитать число Фибоначчи //");
                Console.Write("Введите число: ");
                int value = int.Parse(Console.ReadLine());
                int result = Fibonachi(value);
                Console.WriteLine("Число = " + result);

                int Fibonachi(int n)
                {
                    if (n == 0 || n == 1) return n;
                    {
                        return Fibonachi(n - 1) + Fibonachi(n - 2);
                    }
                }
            }

            if (number == 2)
            {
                Console.WriteLine ("// Вы выбрали посчитать факториал //");
                Console.Write("Введите число: ");
                int value = int.Parse(Console.ReadLine());
                int result = Factorial(value);
                Console.WriteLine("Число = " + result);
                int Factorial(int n)
                {
                    if (n == 1) return 1;

                    return n * Factorial(n - 1);
                }
            }
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 6";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 6;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №6. Тема: Рекурсивная функция чисел Фибоначчи и факториала";
        }
    }
}
