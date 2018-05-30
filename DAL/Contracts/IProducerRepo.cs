using System.Collections.Generic;
using MVCTask.Models;

namespace MVCTask.DAL.Contracts
{
    interface IProducerRepo
    {
        IEnumerable<Producer> GetAll();
    }
}
