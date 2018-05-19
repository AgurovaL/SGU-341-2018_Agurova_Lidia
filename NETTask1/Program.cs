using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyramid = FileRW.Read("pyramid.txt");
            pyramid.ChangeTopPoint(new Point(10, 10, 25));
            FileRW.Write(pyramid, "out.txt");
        }
    }
}
