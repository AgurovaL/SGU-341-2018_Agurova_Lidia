using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETTask2Part2
{
    class Ring
    {
        private Round outRound;
        private Round inRound;
        public Round OutRound { get; set; }
        public Round InRound { get; set; }
        public Ring(double centerX, double centerY, double outRadius, double inRadius)
        {
            if (outRadius < inRadius)
            {
                throw new ArgumentException("Внешний радиус должнен быть больше");
            }
            else
            {
                this.OutRound = new Round(outRadius, centerX, centerY);
                this.InRound = new Round(inRadius, centerX, centerY);
            }
        }
        public Ring(Round outRount, Round inRound)
        {
            if (outRount == null || inRound == null)
            {
                throw new NullReferenceException("Окружности пусты");
            }
            else
            {
                this.OutRound = outRount;
                this.InRound = inRound;
            }           
        }

        //площадь кольца
        public double GetSquare()
        {
            return OutRound.GetSquare();
        }

        //суммарную длину внешней и внутренней окружностей
        public double GetLength()
        {
            return InRound.GetLength() + OutRound.GetLength();
        }
    }
}
