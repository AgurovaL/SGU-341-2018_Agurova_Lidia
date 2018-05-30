using MVCTask.Controllers;
using MVCTask.Models;
using System;

namespace MVCTask.Views
{
    public class AddStore: IAdd
    {
        public void Add()
        {
            Console.WriteLine("------------adding new store----------------");
            Console.WriteLine("Enter store adress:");
            string adress = Console.ReadLine();
            int? result = new StoreController().AddStore(adress);
            if (result >= 0)
            {
                Console.WriteLine("The new store ID is {0}. New store has been added", result);
            }
            else
            {
                Console.WriteLine("The new store ID is {0}. Something went wrong.", result);
            }
        }
    }
}
