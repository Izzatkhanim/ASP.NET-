using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Setting : BaseEntity
    {
        [Required]
        public string Logo { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string OfficeTime { get; set; }

        [Required]
        public string NeedAnAgentNumber { get; set; }

        public SocialMedia SocialMedia { get; set; }
    }
}
