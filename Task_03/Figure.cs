using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Figure
    {
        Point[] point;
        string type;
        public string Type { get { return type; } }

        double LengthSide(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow((pointB.X - pointA.X), 2) + Math.Pow((pointB.Y - pointA.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < point.Length-1; i++) // суммируем стороны фигуры 1 с 2, 2 с 3 и т.д.
            {
                sum += LengthSide(point[i], point[i + 1]);
            }
            sum += LengthSide(point[point.Length-1], point[0]); // добавляем длину n-точки с 1й точкой
            Console.Write(sum);
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            point = new Point[3];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            type = "Треугольник";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            point = new Point[4];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
            type = "Четырехугольник";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            point = new Point[5];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
            point[4] = point5;
            type = "Пятиугольник";
        }

    }
}
