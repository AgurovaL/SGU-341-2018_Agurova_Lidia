using System.Collections.Generic;
using MVCTask.Models;


namespace MVCTask.DAL.Contracts
{
    interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        int? Add(int id_product_group, int id_producer, string name);
        int? Delete(string name);
        int? Delete(int id);
    }
}
