using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class SocialMedia : BaseEntity
    {
        [Required]
        public string Icon { get; set; }

        [Required]
        public string Link { get; set; }
    }
}
