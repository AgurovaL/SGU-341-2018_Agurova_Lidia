using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTask.Controllers;
using MVCTask.Views.showAll;

namespace MVCTask.Views.add
{
    class AddProduct: IAdd
    {
        public void Add()
        {
            Console.WriteLine("------------adding new product----------------");

            Console.WriteLine("ID of product group.\nYou can press '1' to get the products group list or 'Ent' to enter id:");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                new ShowAllProductGroups().ShowAll();
            }
            Console.WriteLine("Enter id of product group:");
            int id_product_group = Int32.Parse(Console.ReadLine());


            Console.WriteLine("ID of producer.\nYou can press '1' to get the producers list or 'Ent' to enter id:");
            if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                new ShowAllProducers().ShowAll();
            }
            Console.WriteLine("Enter id of producer:");
            int id_producer = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();

            int? result = new ProductController().AddProduct(id_product_group, id_producer, name);
            if (result >= 0)
            {
                Console.WriteLine("The new product ID is {0}. New product has been added", result);
            }
            else
            {
                Console.WriteLine("The new product ID is {0}. Something went wrong.", result);
            }
        }
    }
}
