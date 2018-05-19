using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask2Part2
{
    //Создать класс Ring, описывающий кольцо, заданное координатами центра, внешним и внутренним радиусами,
    // а также свойствами, позволяющими узнать площадь кольца и суммарную длину внешней и внутренней окружностей.

    class Program
    {
        static void Main(string[] args)
        {
            Ring ring = new Ring(1, 1, 5, 25);
            Console.WriteLine(ring.GetSquare());
            Console.WriteLine(ring.GetLength());           
        }
    }
}
