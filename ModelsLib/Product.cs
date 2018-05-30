
namespace MVCTask.Models
{
    public class Product
    {
        public Product() { }

        public int ID_product { get; set; }
        public ProductGroup Product_group { get; set; }
        public Producer Producer { get; set; }
        public string Name { get; set; }
    }
}
