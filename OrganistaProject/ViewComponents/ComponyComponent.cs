using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class ComponyComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public ComponyComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var componies = db.Companies.ToList();

            return View(await Task.FromResult(componies));
        }
    }
}
