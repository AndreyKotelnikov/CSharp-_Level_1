﻿using System;

#region 
/*Котельников Андрей 
 *Kурс C# Уровень 1
 *Урок 1
 *Практическая часть */
#endregion


namespace C_Sharp_Level_1
{
    class Program
    {
        static double EnterNumber(string nameOfNumber)
        {
            string answer;
            double number;

            while (true)
            {
                Console.WriteLine("Введите " + nameOfNumber + ":");
                answer = Console.ReadLine();
                if (Double.TryParse(answer, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Требуется ввести число. Попробуйте ещё раз\n");
                }
            }
        }

        static void Main(string[] args)
        {
            //Задача 1.Написать программу сложения двух чисел.
            double firstNumber;
            double secondNumber;
            double summa;

            firstNumber = EnterNumber("первое число");
            secondNumber = EnterNumber("второе число");

            summa = firstNumber + secondNumber;

            Console.WriteLine("\n" + firstNumber + " + " + secondNumber + " = " + summa);

            //Задача 2.Вывести значение функции ax ^ 2 + bx + c в точке x.x — ввести с клавиатуры, a,b и c — присвоить в программе.
            { 
                double a = 10;
                double b = 10;
                double c = 10;
                double x;

                x = EnterNumber("значение X");

                Console.WriteLine("\nКвадратное уравнение: {0}*x^2 + {1}*x + {2} в точке X={3} имеет значение: {4}", a, b, c, x, a * Math.Pow(x, 2) + b * x + c);
            }

            //Задача 3. Обменять значениями две переменные.
            {
                double a = 20;
                double b = 30;
                double temp = a;
                a = b;
                b = temp;
            }

            Console.ReadLine();
        }
    }
}
