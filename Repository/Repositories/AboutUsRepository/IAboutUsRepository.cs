using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;

namespace Repository.Repositories.AboutUsRepository
{
   public interface IAboutUsRepository
    {
        IEnumerable<AboutUs> GetAboutUs();
    }
}
