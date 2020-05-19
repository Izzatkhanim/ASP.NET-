using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public string Review { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }
    }
}
