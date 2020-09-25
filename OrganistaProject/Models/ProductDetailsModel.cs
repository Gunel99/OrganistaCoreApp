using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class ProductDetailsModel
    {
        public Product Product { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public Category Category { get; set; }
        public CommentFromPage CommentFromPage { get; set; }

    }
}
