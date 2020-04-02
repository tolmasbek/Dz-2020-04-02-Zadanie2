﻿using System;

namespace dz_zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  • Задание 2
             *      A. Создайте проект по шаблону Console Application.
             *      B. Требуется: создать класс с именем Rectangle.
             *          1. В теле класса создать два поля, описывающие длины сторон:
             *              • double side1, side2.
             *              • Создать пользовательский конструктор Rectangle(double side1, double side2),
             *                в теле которого поля side1 и side2 инициализируются значениями аргументов.
             *              • Создать два метода:
             *                  o double AreaCalculator() - вычисляющие площадь прямоугольника:
             *                  o double PerimeterCalculator() - периметр прямоугольника.
             *              • Создать два свойства double Area и double Perimeter с одним методом
             *                доступа get.
             *              • Написать программу, которая принимает от пользователя длины двух
             *              сторон прямоугольника и выводит на экран периметр и площадь.
             */
    


            Console.ReadKey();
        }
        class Rectangle
        {
            public double side1;
            public double side2;
            public double Area { get; }
            public double Perimeter { get; }
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double AreaCalculator()
            {
                return side1 * side2;
            }
            public double PerimeterCalculator()
            {
                return 2 * (side1 + side2);
            }         
        }
    }
}
