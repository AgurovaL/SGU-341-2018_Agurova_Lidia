using System.Data.Linq.Mapping;

namespace MVCTask.Models
{
    [Table(Name = "Store")]
    public class Store
    {
        public Store() {}
        public Store (string adress){Adress = adress;}

        [Column(IsPrimaryKey = true, Storage = "_ID_store")]
        public int ID_store { get; set; }

        private string adress;
        [Column(Storage = "_Adress")]
        public string Adress {
            get { return adress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Adress string is null!");
                }
                else
                {
                    adress = value;
                }
            }
        }
    }
}
