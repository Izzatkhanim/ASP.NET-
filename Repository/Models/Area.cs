using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Area : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(100)]
        public string ActionText { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string ImageText { get; set; }

        [Required]
        public string Video { get; set; }

        [Required]
        public string Endpoint { get; set; }
    }
}
