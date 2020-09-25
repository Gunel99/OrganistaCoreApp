using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Order
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public enum EnumOrderState
    {
        [Display(Name= "Awaiting approval")]
        Waiting,
        [Display(Name = "Approval completed")]
        Completed
    }
}
