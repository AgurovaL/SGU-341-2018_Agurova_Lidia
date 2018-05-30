using MVCTask.Controllers;
using System;

namespace MVCTask.Views.delete
{
    class DeleteStore:IDelete
    {
        public void Delete()
        {
            Console.WriteLine("------------deleting store----------------");
            Console.WriteLine("Do you want to delete by ID or ADRESS");
            string column = Console.ReadLine();
            int? result = -1;

            switch (column)
            {
                case "ADRESS":
                    Console.WriteLine("Enter store adress:");
                    string adress = Console.ReadLine();
                    result = new StoreController().DeleteStore(adress);
                    break;
                case "ID":
                    Console.WriteLine("Enter store id:");
                    int id = Int32.Parse(Console.ReadLine());
                    result = new StoreController().DeleteStore(id);
                    break;
                default:
                    Console.WriteLine("Wrong enter!");
                    break;
            }

            if (result > 0)
            {
                Console.WriteLine("Number of deleted strings is {0}. The store has been deleted", result);         
            }
            else
            {
                Console.WriteLine("Number of deleted strings is {0}. Something went wrong.", result);    
            }
        }

        
    }
}
