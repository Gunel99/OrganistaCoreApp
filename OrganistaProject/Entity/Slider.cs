using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Title teleb olunur!"), StringLength(50, ErrorMessage = "Minimum 50 characterden cox ola bilmez!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content teleb olunur!"), StringLength(200, ErrorMessage = "Minimum 200 characterden cox ola bilmez!")]
        public string Content { get; set; }
    }
}
