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
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Email { get; set; }

        public AboutUsItem AboutUsItem { get; set; }

        

    }
}
