using System.Data.Linq.Mapping;

namespace MVCTask.Models
{
    [Table(Name = "Product_group")]
    public class ProductGroup
    {
        public ProductGroup() { }
        public ProductGroup(string name)
        {
            Name = name;
        }
        [Column(IsPrimaryKey = true, Storage = "_ID_product_group")]
        public int ID_product_group { get; set; }

        [Column(Storage = "_Name")]
        public string Name { get; set; }
    }
}