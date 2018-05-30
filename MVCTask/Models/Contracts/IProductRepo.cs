using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVCTask.Models
{
    interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        bool Add(Product product);
        bool Delete(Product product);
        bool Delete(int id);
    }
}
