using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class BlogTestimonialComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public BlogTestimonialComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonial = db.Testimonials.ToList().Take(1);

            return View(await Task.FromResult(testimonial));
        }
    }
}
