using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Создать классы Point и Figure. 
             * Класс Point должен содержать два целочисленных поля и одно строковое поле. 
             * Создать три свойства с одним методом доступа get. Создать пользовательский конструктор, 
             * в теле которого проинициализируйте поля значениями аргументов. 
             * Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
             * Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; 
             * void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
             * Написать программу, которая выводит на экран название и периметр многоугольника. 
             */

            Figure figure = new Figure
                (
                    new Point("A", 1, 1),
                    new Point("B", 2, 2),
                    new Point("C", 0, 3)
                );

            Console.Write($"{figure.Type}, периметр = ");
            figure.PerimeterCalculator();

            Figure figure1 = new Figure
            (
                new Point("A", 1, 1),
                new Point("B", 2, 2),
                new Point("C", 0, 3),
                new Point("D", 5, 2)
            );

            Console.Write($"\n{figure1.Type}, периметр = ");
            figure1.PerimeterCalculator();

            Figure figure2 = new Figure
            (
                new Point("A", 1, 1),
                new Point("B", 2, 2),
                new Point("C", 0, 3),
                new Point("D", 5, 2),
                new Point("C", 7, 3)
            );

            Console.Write($"\n{figure2.Type}, периметр = ");
            figure2.PerimeterCalculator();


            Console.ReadKey();

        }
    }
}
