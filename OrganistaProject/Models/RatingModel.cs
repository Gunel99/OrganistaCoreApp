using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class RatingModel
    {
        public Product Product { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }
}
