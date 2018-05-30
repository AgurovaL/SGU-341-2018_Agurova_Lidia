using System.Data.Linq.Mapping;

namespace MVCTask.Models
{
    [Table(Name = "Product")]
    public class Product
    {
        public Product() { }
        public Product(int id_product_group, int id_producer, string name)
        {
            ID_product_group = id_product_group;
            ID_producer = id_producer;
            Name = name;
        }
        [Column(IsPrimaryKey = true, Storage = "_ID_product")]
        public int ID_product { get; set; }

        [Column(Storage = "_ID_product_group")]
        public int ID_product_group { get; set; }

        [Column(Storage = "_ID_producer")]
        public int ID_producer { get; set; }

        [Column(Storage = "_Name")]
        public string Name { get; set; }
    }
}
