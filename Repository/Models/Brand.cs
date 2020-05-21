using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class Brand : BaseEntity
    {
        [Required]
        public string Logo { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
