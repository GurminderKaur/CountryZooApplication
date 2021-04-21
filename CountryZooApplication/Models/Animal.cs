using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountryZooApplication.Models
{
    public class Animal
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Species cannot exceed 50 characters")]
        public string Species { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
        [Display(Name = "Animal Name")]
        public string Name { get; set; }
        [Required]
        public double? Weight { get; set; }

    }


}
