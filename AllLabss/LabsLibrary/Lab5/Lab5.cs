﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab5
{
    internal class Lab5
    {
        /// <summary>
        /// Метод демонстрации всех заданий лабораторной работы
        /// </summary>  
        public void Demo()
        {
            Matrica exemp1 = new Matrica(5, 5);

            exemp1.Random();
            exemp1.Print();

            Console.WriteLine("Сумма:" + exemp1.Sum());

            Console.WriteLine();
            exemp1.GlavDiag();

            Console.WriteLine();
            exemp1.PassivDiag();

            Console.ReadKey();
        }
        /// <summary>
        /// Метод возвращает описание заданий лабораторной работы
        /// </summary>
        /// <returns></returns>
        /// <returns>Описание лабы</returns>
        public string Description()
        {
            return "Задание 5";
        }
        /// <summary>
        /// Метод возвращает номер лабораторной работы
        /// </summary>
        /// <returns>Номер лабы</returns>
        public int Id()
        {
            return 5;
        }
        /// <summary>
        /// Метод возвращает заголовок лабораторной работы
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная №5. Тема: ООП";
        }
    }
}