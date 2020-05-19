using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class BestPlan : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }

        [Required]
        [MaxLength(50)]
        public string PlanName { get; set; }

        [Required]
        public string PlanLogo { get; set; }

        [Required]
        public string PlanDescription { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string SubDescription { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string ImageText { get; set; }


    }
}
