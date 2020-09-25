using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class ContactComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public ContactComponent(AppDbContext _db)
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
