using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category-ni qeyd edin!")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
