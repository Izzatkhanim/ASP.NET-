using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class ContactUs : BaseEntity
    {
        [Required]
        public string Location { get; set; }

        [Required]
        public string Email1 { get; set; }

        [Required]
        public string Email2 { get; set; }

        [Required]
        public string Phone1 { get; set; }

        [Required]
        public string Phone2 { get; set; }

        [Required]
        public string OpeningHours { get; set; }
    }
}
