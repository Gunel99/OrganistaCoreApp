using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Ad daxil edin!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Profession daxil edin!")]
        public string Profession { get; set; }
        [Required(ErrorMessage = "Description daxil edin!")]
        public string Description { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
    }
}
