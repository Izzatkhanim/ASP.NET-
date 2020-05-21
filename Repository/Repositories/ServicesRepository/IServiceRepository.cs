using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.ServicesRepository
{
    public interface IServiceRepository
    {
        IEnumerable<Service> GetServices();
    }
}
