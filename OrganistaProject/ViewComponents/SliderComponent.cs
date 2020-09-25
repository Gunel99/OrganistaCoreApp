using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class SliderComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public SliderComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slider = db.Sliders.ToList();

            return View(await Task.FromResult(slider));
        }
    }
}
