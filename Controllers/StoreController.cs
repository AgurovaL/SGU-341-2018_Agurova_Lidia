using MVCTask.DAL;
using MVCTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCTask.Controllers
{
    public class StoreController
    {
        private static StoreRepo stores;

        public StoreController()
        {
            stores = new StoreRepo();
        }

        public int? AddStore(string adress)
        {
            if (string.IsNullOrEmpty(adress))
            {
                throw new Validation.ValidationException("Store adress is empty!", "adress");
            }
            else
                return stores.Add(adress);
        }

        public List<Store> ShowAllStores()
        {
            List<Store> storeList = stores.GetAll().ToList();
            if (storeList == null)
            {
                throw new Validation.ValidationException("Store list is empty!", "storeList");
            }
            else
                return storeList;        
        }

        public int? DeleteStore(string adress)
        {
            if (string.IsNullOrEmpty(adress))
            {
                throw new Validation.ValidationException("Store adress is empty!", "adress");
            }
            else
                return stores.Delete(adress);
        }

        public int? DeleteStore(int id)
        {
            if (id < 0)
            {
                throw new Validation.ValidationException("ID is negative!", "id");
            }
            else
                return stores.Delete(id);
        }
    }
}
