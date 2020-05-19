using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Service : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }

        [Required]
        public string Logo { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
