using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask2Part2
{
    class Round
    {
        private Point center;
        private double radius;
        public Round(double radius)
        {
            this.Radius = radius;
        }
        public Round(double radius, double centerX, double centerY)
        {
            this.Radius = radius;
            this.center = new Point(centerX, centerY);
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным");
                }
                else
                    this.radius = value;
            }
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
