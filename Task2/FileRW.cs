using System;
using System.IO;

namespace Task2
{
    class FileRW
    {
        public static User Read(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Такого файла не существует");
            }
            else
            {
                char[] separators = { ';' };
                using (StreamReader reader = new StreamReader(filename))
                {
                    string[] lines = reader.ReadLine().Split(separators); //получить строку с данными
                    if (lines == null)
                    {
                        throw new Exception("На вход подавалась пустая строка");
                    }
                    else
                    {
                        //string lastName, string firstName, string middleName, DateTime dateOfBirt
                        User user = new User(lines[0], lines[1], lines[2], DateTime.Parse(lines[3]));
                        return user;
                    }
                }
            }
        }

        public static void Write(User user, string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                if (user == null)
                {
                    throw new NullReferenceException("Список точек не может быть пуст");
                }
                else
                {
                    writer.WriteLine("{0};{1};{2};{3};{4}",
                       user.LastName, user.FirstName, user.MiddleName, user.DateOfBirth, user.Age);
                }
            }
        }
    }
}
