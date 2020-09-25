using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Areas.AdminOrganista.Models;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Areas.AdminOrganista.ViewComponents
{
    public class CounterComponent : ViewComponent
    {
        private readonly AppDbContext db;

        public CounterComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            CounterModel model = new CounterModel
            {
                Orders = db.Orders.ToList(),
                Blogs = db.Blogs.ToList(),
                Products = db.Products.ToList(),
                Users = db.Users.ToList(),
                Authors = db.Authors.ToList(),
                Categories = db.Categories.ToList(),
                Images = db.BlogDescImages.ToList(),
                FollowImages = db.FollowImages.ToList(),
                Sliders = db.Sliders.ToList(),
                Companies = db.Companies.ToList()
            };

            return View(await Task.FromResult(model));
        }

    }
}
