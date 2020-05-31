using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Themegeniuslab.Models
{
    public class AboutUsViewModel
    {
        public string Logo { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Endpoint { get; set; }

        public string ActionText { get; set; }

        public AboutUsItem AboutUsItem { get; set; }
    }
}
