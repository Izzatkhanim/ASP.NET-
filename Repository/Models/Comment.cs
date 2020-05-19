using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Comment : BaseEntity
    {
       
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime Date { get; set; }
    }
}
