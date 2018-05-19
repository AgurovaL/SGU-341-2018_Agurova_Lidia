using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask3Part1
{
    class Line: Figure
    {
        private List<float> pointsList;
        public Line(List<float> pointsList) //конструктор
        {
            this.PointsList = pointsList;
        }
        public List<float> PointsList
        {
            get
            {
                return pointsList;
            }
            set
            {
                if (value == null || value.Count != 4)
                    throw new NullReferenceException("Список координат не может быть null и должен содержать 4 координаты");
                else
                {
                    this.pointsList = value;
                }       
            }
        }
        public override void Draw(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new NullReferenceException("Строка с цветом не должна быть пустой");
            else
                Console.WriteLine("{0} line has been drawn", color);
        }
        public override void Print()
        {
            Console.WriteLine("Line: {0};{1}-{2};{3}", pointsList[0], pointsList[1], pointsList[2], pointsList[3]);
        }
    }
}
