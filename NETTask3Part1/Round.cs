using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask3Part1
{
    class Round:Figure
    {
        private List<float> centerList;
        private float radius;
        public Round(List<float> centerList, float radius) //конструктор
        {
            this.CenterList = centerList;
            this.Radius = radius;
        }
        public List<float> CenterList
        {
            get
            {
                return centerList;
            }
            set
            {
                if (value == null || value.Count != 2)
                    throw new NullReferenceException("Список координат не может быть null и должен содержать 2 координаты");
                else
                {
                    this.centerList = value;
                }
            }
        }
        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Радиус не может быть меньше 0");
                else
                    this.radius = value;
            }
        }
        public override void Draw(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new NullReferenceException("Строка с цветом не должна быть пустой");
            else
                Console.WriteLine("{0} round has been drawn", color);
        }
        public override void Print()
        {
            Console.WriteLine("Round: {0};{1}-radius={2}", centerList[0], centerList[1], radius);
        }
    }
}
