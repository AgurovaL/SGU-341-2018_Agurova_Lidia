using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCTask.Controllers;
using MVCTask.Models;

namespace MVCTask.Views.showAll
{
    class ShowAllProducers : IShowAll
    {
        public void ShowAll()
        {
            Console.WriteLine("------------Producers----------------");
            List<Producer> producersList = new ProducerController().ShowAllProducers();
            foreach (Producer producer in producersList)
            {
                Console.WriteLine("ID: {0}   Name: {1}   Adress: {2}", producer.ID_producer, producer.Name, producer.Adress);
            }
        }
    }
}
