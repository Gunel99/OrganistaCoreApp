using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Mehsulun adini qeyd edin!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mehsulun qiymetini qeyd edin!")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Mehsulun metinini qeyd edin!")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Mehsul description qeyd edin!")]
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
    }
}
