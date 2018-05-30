using System;
using System.Collections.Generic;
using MVCTask.Controllers;
using MVCTask.Models;

namespace MVCTask.Views.showAll
{
    class ShowAllProducts: IShowAll
    {
        public void ShowAll()
        {
            Console.WriteLine("------------Products----------------");
            List<Product> productsList = new ProductController().ShowAllProducts();
            foreach (Product product in productsList)
            {
                Console.WriteLine("ID: {0}   product group: {1}   producer: {2}   adress: {3}",
                    product.ID_product,
                    product.Product_group.Name,
                    product.Producer.Name,
                    product.Producer.Adress);
                Console.WriteLine("name: {0}", product.Name);
            }
        }
    }
}
