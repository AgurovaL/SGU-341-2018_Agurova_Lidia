using MVCTask.Controllers;
using MVCTask.Models;
using System;
using System.Collections.Generic;

namespace MVCTask.Views.showAll
{
    public class ShowAllStores: IShowAll
    {
        public void ShowAll()
        {
            Console.WriteLine("------------Stores----------------");
            List<Store> storeList = new StoreController().ShowAllStores();
            foreach (Store store in storeList)
            {
                Console.WriteLine("ID: {0} Adress: {1}", store.ID_store, store.Adress);
            }
        }
    }
}
