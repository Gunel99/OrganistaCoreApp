using OrganistaProject.Entity;
using OrganistaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Areas.AdminOrganista.Models
{
    public class CounterModel
    {
        public List<Product> Products { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Order> Orders { get; set; }
        public List<AppUser> Users { get; set; }
        public List<Author> Authors { get; set; }
        public List<Category> Categories { get; set; }
        public List<BlogDescImage> Images { get; set; }
        public List<FollowImage> FollowImages { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Company> Companies { get; set; }
    }
}
