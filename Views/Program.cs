using MVCTask.Views;
using MVCTask.Views.showAll;
using MVCTask.Views.delete;
using MVCTask.Views.add;
namespace MVCTask
{
    class Program
    {
        static void Main(string[] args)
        {
            new ShowAllStores().ShowAll();
            new AddStore().Add();
            new ShowAllStores().ShowAll();
            new DeleteStore().Delete();
            new ShowAllStores().ShowAll();

            new ShowAllProducts().ShowAll();
            new AddProduct().Add();
            new ShowAllProducts().ShowAll();
            new DeleteProduct().Delete();
            new ShowAllProducts().ShowAll();
        }
    }
}
