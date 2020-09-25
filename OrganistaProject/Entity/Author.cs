using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Muellif ad ve soyadini daxil edin!")]
        public string Fullname { get; set; }
        public DateTime PostedDate { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
