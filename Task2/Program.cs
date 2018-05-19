using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("Ivanov", "Ivan", "Ivanovich", DateTime.Parse("1990-05-01"));
            User user = FileRW.Read("users.txt");
            FileRW.Write(user, "out.txt");

          //  Employee emp = FileRW.Read("users.txt");
          // FileRW.Write(emp, "out.txt");
        }
    }
}
