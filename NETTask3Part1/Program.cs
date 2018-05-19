using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать фигуру выбранного типа по произвольным координатам.
//Вывести фигуры на экран (для каждой фигуры вывести на консоль её тип и значения параметров).
namespace NETTask3Part1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Line line = new Line(new List<float> { 1, 1, 1, 5 });
            line.Draw("red");
            line.Print();

            Round round = new Round(new List<float> { 1, 2}, 5);
            round.Draw("green");
            round.Print();

            Rectangle rect = new Rectangle(new List<Line> {line,
                new Line(new List<float> { 1, 5, 5, 5 }),
                new Line(new List<float> { 5, 5, 5, 1 }),
                new Line(new List<float> { 5, 1, 1, 1 })
            });
            rect.Draw("blue");
            rect.Print();

            Ring ring = new Ring(new List<Round> {round,
                new Round(new List<float> { 1, 2} , 15) });
            ring.Draw("blue");
            ring.Print();
        }
    }
}
