using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDescImage> BlogDescImages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<FollowImage> FollowImages { get; set; }
        public DbSet<MessageFromPage> MessageFromPages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<CommentFromPage> CommentFromPages { get; set; }
        public DbSet<AboutUsFirstDesc> AboutUsFirstDescs { get; set; }
        public DbSet<AboutUsSecondDesc> AboutUsSecondDescs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
