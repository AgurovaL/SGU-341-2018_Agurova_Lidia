using System;
using System.Collections.Generic;
using System.IO;

namespace NETTask1
{
    class FileRW
    {
        public static Pyramid Read(string filename) //создать пирамиду из 5 точек
        {
            if (File.Exists(filename))
            {
                List<Point> pointsList = new List<Point>();
                char[] separators = { ';', ':' };
                using (StreamReader reader = new StreamReader(filename))
                {

                    for (int i = 0; i < 5; i++)
                    {
                        string[] lines = reader.ReadLine().Split(separators); //получить строку с координатами
                        if (lines != null)
                        {
                            Point p = new Point(char.Parse(lines[0]), double.Parse(lines[1]),
                                double.Parse(lines[2]), double.Parse(lines[3]));
                            pointsList.Add(p); //добавить точку в основание    
                        }
                        else throw new Exception("На вход подавалась пустая строка");
                    }

                }
                return new Pyramid(pointsList);
            }
            else
                throw new FileNotFoundException("Такого файла не существует");             
        }//

        public static void Write(Pyramid pyramid, string filename) //создать пирамиду из 5 точек
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                if (pyramid.PointsList != null && pyramid.PointsList.Count == 5)
                {
                    foreach (Point p in pyramid.PointsList)
                    {
                        writer.WriteLine("{0}:{1};{2};{3}", p.Name, p.X, p.Y, p.Z);
                    }
                    writer.WriteLine("Base Square:{0}", pyramid.BaseSquare);
                    writer.WriteLine("Volume:{0}", pyramid.Volume);
                }
                else
                    throw new NullReferenceException("Список точек не может быть пуст");
            }
        }
    }
}
