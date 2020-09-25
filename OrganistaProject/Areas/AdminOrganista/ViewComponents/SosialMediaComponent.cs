using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Areas.AdminOrganista.ViewComponents
{
    public class SosialMediaComponent : ViewComponent
    {
        private readonly AppDbContext db;

        public SosialMediaComponent(AppDbContext _db)
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
