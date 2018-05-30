using System.Collections.Generic;
using System.Linq;
using MVCTask.Models;
using MVCTask.DAL;

namespace MVCTask.Controllers
{
    public class ProductController
    {
        private static ProductRepo products;

        public ProductController()
        {
            products = new ProductRepo();
        }

        public int? AddProduct(int id_product_group, int id_producer, string name)
        {
            if (id_product_group < 0 || id_producer < 0)
            {
                throw new Validation.ValidationException("ID is negative!", "id");
            }
            else
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Validation.ValidationException("Product name is empty", "name");
                }
                else
                    return products.Add(id_product_group, id_producer, name);
            }      
        }

        public List<Product> ShowAllProducts()
        {
            List<Product> productList = products.GetAll().ToList();
            if (productList == null)
            {
                throw new Validation.ValidationException("Product list is empty!", "productList");
            }
            else
                return productList;
        }

        public int? DeleteProduct(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Validation.ValidationException("Product name is empty!", "name");
            }
            else
            {
                Product product = new Product();
                product.Name = name;
                return products.Delete(name);
            }
                
        }

        public int? DeleteProduct(int id)
        {
            if (id < 0)
            {
                throw new Validation.ValidationException("ID is negative!", "id");
            }
            else
                return products.Delete(id);
        }
    }
}
