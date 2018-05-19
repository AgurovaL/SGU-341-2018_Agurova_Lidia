using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask1
{
    class Point
    {      
        public char Name { get; set; }
        public double X { get; set; }  //первая координата
        public double Y { get; set; } //вторая координата
        public double Z { get; set; }  //третья координата      

        public Point(char name, double x, double y, double z)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.Z = z;        
        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static double Length(Point p1, Point p2) //вычисляет расстояние между точками
        {
            if (p1 != null && p2 != null)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2));
            }
            else
                throw new NullReferenceException("Передаваемые точки не могут быть null");
        }
    }
}
