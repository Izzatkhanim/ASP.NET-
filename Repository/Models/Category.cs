using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
