using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask.Models
{
    interface IStoreRepo
    {
        IEnumerable<Store> GetAll();
        bool Add(Store store);
        bool Delete(Store store);
        bool Delete(int id);
    }
}
