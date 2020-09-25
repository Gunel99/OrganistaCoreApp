using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.DAL;
using OrganistaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class RatingComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public RatingComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ratingModel = db.OrderLines.Include(o => o.Product).ToList();

            return View(await Task.FromResult(ratingModel));
        }
    }
}
