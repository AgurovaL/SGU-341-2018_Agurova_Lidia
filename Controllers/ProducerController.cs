using MVCTask.DAL;
using MVCTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCTask.Controllers
{
    public class ProducerController
    {
        private static ProducerRepo producers;

        public ProducerController()
        {
            producers = new ProducerRepo();
        }

        public List<Producer> ShowAllProducers()
        {
            List<Producer> producersList = producers.GetAll().ToList();
            if (producersList == null)
            {
                throw new Validation.ValidationException("Producers list is empty!", "producersList");
            }
            else
                return producersList;
        }
    }
}
