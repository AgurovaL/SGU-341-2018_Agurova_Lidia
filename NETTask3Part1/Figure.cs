using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask3Part1
{
    abstract class Figure: IDrawable, IPrintable
    {
        public abstract void Draw(string color);    
        public abstract void Print();
    }
}
