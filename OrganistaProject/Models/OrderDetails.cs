using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class OrderDetails
    {
        [Required(ErrorMessage = "Zehmet olmasa, addressi daxil edin!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa, olkeni daxil edin!")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa, seheri daxil edin!")]
        public string City { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa, telefon nomresini daxil edin!")]
        public string PhoneNumber { get; set; }
    }
}
