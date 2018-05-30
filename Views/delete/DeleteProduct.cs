using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTask.Controllers;

namespace MVCTask.Views.delete
{
    class DeleteProduct : IDelete
    {
        public void Delete()
        {
            Console.WriteLine("------------deleting product----------------");
            Console.WriteLine("Do you want to delete by ID or NAME");
            string column = Console.ReadLine();
            int? result = -1;
            switch (column)
            {
                case "NAME":
                    Console.WriteLine("Enter product name:");
                    string name = Console.ReadLine();
                    result = new ProductController().DeleteProduct(name);
                    break;
                case "ID":
                    Console.WriteLine("Enter product id:");
                    int id = Int32.Parse(Console.ReadLine());
                    result = new ProductController().DeleteProduct(id);
                    break;
                default:
                    Console.WriteLine("Wrong enter((");
                    break;
            }

            if (result == 1)
            {
                Console.WriteLine("Number of deleted strings is {0}. The product has been deleted", result);
            }
            else
            {
                Console.WriteLine("Number of deleted strings is {0}. Something went wrong.", result);
            }
        }

    }
}
