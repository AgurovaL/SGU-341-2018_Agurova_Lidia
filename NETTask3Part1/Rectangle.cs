using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask3Part1
{
    class Rectangle: Figure
    {
        private List<Line> linesList;
        public Rectangle(List<Line> linesList) //конструктор
        {
            this.LinesList = linesList;
        }
        public List<Line> LinesList
        {
            get
            {
                return linesList;
            }
            set
            {
                if (value == null || value.Count != 4)
                    throw new NullReferenceException("Список линий не может быть null и должен содержать 4 линии");
                else
                {
                    this.linesList = value;
                }
            }
        }
        public override void Draw(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new NullReferenceException("Строка с цветом не должна быть пустой");
            else
                Console.WriteLine("{0} rectangle has been drawn", color);
        }
        public override void Print()
        {
            Console.WriteLine("Rectangle: ");
            foreach (Line line in LinesList)
            {
                line.Print();
            }
        }
    }
}
