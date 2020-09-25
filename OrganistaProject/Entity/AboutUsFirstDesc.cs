using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class AboutUsFirstDesc
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required, StringLength(450)]
        public string Description { get; set; }
    }
}
