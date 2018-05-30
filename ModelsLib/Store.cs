using System.Data.Linq.Mapping;

namespace MVCTask.Models
{
    public class Store
    {
        public Store() {}
        public Store (string adress){Adress = adress;}

        public int ID_store { get; set; }
        public string Adress { get; set; }
    }
}
