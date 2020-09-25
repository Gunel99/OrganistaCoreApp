using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class TestimonialComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public TestimonialComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var testimonial = db.Testimonials.ToList();

            return View(await Task.FromResult(testimonial));
        }
    }
}
