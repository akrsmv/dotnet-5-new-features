using DataAccessDapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Models
{
    public class DisplayCountryModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Country name must be more than 5 symbols")]
        [MaxLength(15, ErrorMessage = "Country name must be less than 15 symbols")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Country code must be more than 2 symbols")]
        [MaxLength(3, ErrorMessage = "Country code must be less than 3 symbols")]
        public string Code { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Country currency must be more than 2 symbols")]
        [MaxLength(3, ErrorMessage = "Country currency must be less than 3 symbols")]
        public string Currency { get; set; }
    }
}
