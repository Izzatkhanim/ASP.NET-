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

        [MaxLength(100)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(200)]
        public string Text { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Image { get; set; }


    }
}
