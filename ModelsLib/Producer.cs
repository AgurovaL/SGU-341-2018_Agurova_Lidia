using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTask.Models
{
    public class Producer
    {
        public Producer() { }
        public Producer(string name, string adress)
        {         
            Name = name;
            Adress = adress;
        }

        public int ID_producer { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
