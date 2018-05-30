using System.Collections.Generic;
using MVCTask.Models;

namespace MVCTask.DAL.Contracts
{
    interface IStoreRepo
    {
        IEnumerable<Store> GetAll();
        int? Add(string adress);
        int? Delete(string adress);
        int? Delete(int id);
    }
}
