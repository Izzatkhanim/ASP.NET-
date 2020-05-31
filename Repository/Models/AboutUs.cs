using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class AboutUs : BaseEntity
    {
        [Required]
        public string Logo { get; set; }
                
        [Required]
        public string Endpoint { get; set; }

        public AboutUsItem AboutUsItem { get; set; }

        

    }
}
