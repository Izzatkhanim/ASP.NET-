using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class AboutUsItem : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Subtext { get; set; }

        [Required]
        [MaxLength(200)]
        public string Text { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MaxLength(200)]
        public string ActionText { get; set; }


        [Required]
        public string Phone { get; set; }

        [Required]
        public string Image { get; set; }


        [Required]
        [MaxLength(200)]
        public string Endpoint { get; set; }


    }
}
