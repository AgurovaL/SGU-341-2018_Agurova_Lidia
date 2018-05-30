using System.Data.Linq.Mapping;

namespace MVCTask.Models
{
    public class ProductGroup
    {
        public ProductGroup() { }
        public ProductGroup(string name)
        {
            Name = name;
        }       

        public int ID_product_group { get; set; }
        public string Name { get; set; }
    }
}