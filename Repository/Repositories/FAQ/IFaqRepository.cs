using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.FAQ
{
    public interface IFaqRepository
    {
        IEnumerable<Faq> GetFaqs();
    }
}
