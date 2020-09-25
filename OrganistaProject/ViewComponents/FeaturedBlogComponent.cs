using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class FeaturedBlogComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public FeaturedBlogComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blogs = db.Blogs.ToList().Take(3);
            return View(await Task.FromResult(blogs));
        }
    }
}
