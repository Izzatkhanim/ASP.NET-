using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class ServiceSpec : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(50)]
        public string Value { get; set; }

        public Service Service { get; set; }


    }
}
