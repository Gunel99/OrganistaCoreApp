using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        private readonly AppDbContext db;
        public HeaderComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = db.Bios.FirstOrDefault();

            return View(await Task.FromResult(bio));
        }
    }
}
