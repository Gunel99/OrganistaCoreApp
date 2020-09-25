using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class AppUser:IdentityUser
    {
        [Required, StringLength(150)]
        public string Fullname { get; set; }
    }
}
