using System;
using System.Collections.Generic;
using MVCTask.Models;

namespace MVCTask.DAL.Contracts
{
    interface IProductGroupRepo
    {
        IEnumerable<ProductGroup> GetAll();
    }
}
