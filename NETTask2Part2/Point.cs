using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask2Part2
{
    class Point
    {
        public char Name { get; set; }
        public double X { get; set; }  //первая координата
        public double Y { get; set; } //вторая координата          

        public Point(char name, double x, double y)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double Length(Point p1, Point p2) //вычисляет расстояние между точками
        {
            if (p1 != null && p2 != null)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            }
            else
                throw new NullReferenceException("Передаваемые точки не могут быть null");
        }
    }
}
