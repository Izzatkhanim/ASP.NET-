using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class SliderItem : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Slogan { get; set; }

        [Required]
        public string ActionText { get; set; }

        [Required]
        public string Image { get; set; }

     
    }
}
