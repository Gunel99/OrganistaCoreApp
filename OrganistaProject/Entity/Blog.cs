using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Blogun adini daxil edin!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Blog metnini daxil edin!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "One cixan metni daxil edin!")]
        public string BoldSentence { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public int BlogDescImageId { get; set; }
        public BlogDescImage BlogDescImage { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
