using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class Blog : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string SecondaryTitle { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Text1 { get; set; }

        [Required]
        public string Text2 { get; set; }

        [Required]
        public string SecondaryText { get; set; }

        [Required]
        public string ActionText { get; set; }

        [Required]
        public string Endpoint { get; set; }
    }
}
