using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class OrderAndOrderLineModel
    {
        public List<Order> Orders { get; set; }
        public OrderLine OrderLine { get; set; }
    }
}
