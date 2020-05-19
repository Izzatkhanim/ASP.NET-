using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Post : BaseEntity
    {
        public string Image { get; set; }

        public string Text { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
