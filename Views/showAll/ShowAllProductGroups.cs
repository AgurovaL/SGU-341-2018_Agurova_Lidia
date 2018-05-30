using System;
using System.Collections.Generic;
using MVCTask.Models;
using MVCTask.Controllers;

namespace MVCTask.Views.showAll
{
    class ShowAllProductGroups : IShowAll
    {
        public void ShowAll()
        {
            Console.WriteLine("------------Product groups----------------");
            List<ProductGroup> productGroupList = new ProductGroupController().ShowAllProductGroups();
            foreach (ProductGroup productGroup in productGroupList)
            {
                Console.WriteLine("ID: {0} Name: {1}", productGroup.ID_product_group, productGroup.Name);
            }           
        }
    }
}
