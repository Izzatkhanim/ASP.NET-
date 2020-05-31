using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class BestPlan : BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string PlanName { get; set; }

        [Required]
        public string PlanDescription1 { get; set; }
        
        public string PlanDescription2 { get; set; }
  
        public string PlanDescription3 { get; set; }
    
        public string PlanDescription4 { get; set; }

        [Required]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }



    }
}
