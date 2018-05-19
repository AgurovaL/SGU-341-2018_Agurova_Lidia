using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask3Part1
{
    class Ring :Figure
    {
        private List<Round> roundList;
        public Ring(List<Round> roundList) //конструктор
        {
            this.RoundList = roundList;
        }
        public List<Round> RoundList
        {
            get
            {
                return roundList;
            }
            set
            {
                if (value == null || value.Count != 2)
                    throw new ArgumentException("Список окружностей не может быть null и должен содержать 2 окружности");
                else
                {
                    if (!value[0].CenterList.SequenceEqual(value[1].CenterList))
                    {
                        throw new ArgumentException("Центры окружностей должны совпадать");
                    }
                    else
                        this.roundList = value;
                }
            }
        }
        public override void Draw(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new NullReferenceException("Строка с цветом не должна быть пустой");
            else
                Console.WriteLine("{0} ring has been drawn", color);
        }
        public override void Print()
        {
            Console.WriteLine("Ring: ");
            foreach (Round round in RoundList)
            {
                round.Print();
            }
        }
    }
}
