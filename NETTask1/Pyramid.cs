using System;
using System.Collections.Generic;
using System.IO;

namespace NETTask1
{
    class Pyramid
    {
        private List<Point> pointsList;

        public Pyramid(List<Point> pointsList) //конструктор
        {
            this.PointsList = pointsList;
        }


        public List<Point> PointsList
        {
            get
            {
                return pointsList;
            }
            set
            {
                if (value != null && value.Count == 5)
                {
                    this.pointsList = value;
                }
               else
                    throw new NullReferenceException
                        ("Список точек не может быть null или содержать меньше/больше 5 точек");
            }
        }
        public double Volume
        {
            get
            {
                //координаты центра основания
                double centerX = PointsList[0].X + (PointsList[1].X - PointsList[0].X) / 2;
                double centerY = PointsList[0].Y + (PointsList[1].Y - PointsList[0].Y) / 2;
                double centerZ = PointsList[0].Z;

                Point center = new Point(centerX, centerY, centerZ); //центр основания
                double h = Point.Length(center, PointsList[4]); //высота

                if (this.BaseSquare != 0)
                {
                    return 1 / 3 * h * this.BaseSquare;
                }
                else
                    throw new Exception("Площадь основания не посчитана");
            }
        }

        public double BaseSquare
        {
            get
            {
                if (PointsList != null && PointsList.Count == 5)
                {
                    double a = Point.Length(PointsList[0], PointsList[1]);
                    return a * a;
                }
                else
                    throw new NullReferenceException("Сначала заполните список точек пирамиды");
            }        
    }

       
        // if (nextIndex >= arr.Length) 
        //throw new IndexOutOfRangeException
        public void ChangeBasePoint(Point newPoint, int pointNumber)
        {
            if (pointNumber >= 0 && pointNumber <= 3 && (newPoint.Z == PointsList[pointNumber].Z) && newPoint != null)
            {
                PointsList[pointNumber] = newPoint;
            }
            else
                throw new Exception("Проверьте номер точки для изменения и новую точку");
        }

        public void ChangeTopPoint(Point newPoint)
        {
            newPoint.Name = 'S';
            if (newPoint!=null)
            {
                PointsList[4] = newPoint;
            }
            else
                throw new Exception("Проверьте новую точку");
        }
    }
}
