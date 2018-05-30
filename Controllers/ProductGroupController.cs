using System.Collections.Generic;
using System.Linq;
using MVCTask.Models;
using MVCTask.DAL;

namespace MVCTask.Controllers
{
    public class ProductGroupController
    {
        private static ProductGroupRepo productGroups;

        public ProductGroupController()
        {
            productGroups = new ProductGroupRepo();
        }

        public List<ProductGroup> ShowAllProductGroups()
        {
            List<ProductGroup> productGroupList = productGroups.GetAll().ToList();
            if (productGroupList == null)
            {
                throw new Validation.ValidationException("Product group list is empty!", "productGroupList");
            }
            else
                return productGroupList;
        }
    }
}
