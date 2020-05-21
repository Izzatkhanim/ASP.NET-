using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Image { get; set; }


    }
}
