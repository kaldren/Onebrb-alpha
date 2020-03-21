using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onebrb.Blazor.Models
{
    public class OnebrbProfile
    {
        [Required(ErrorMessage = "The first name field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The last name field is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "The email field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The country field is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "The city field is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "The about field is required")]
        public string About { get; set; }
        public string PhotoPath { get; set; }
    }
}
