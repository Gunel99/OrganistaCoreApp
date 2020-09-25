using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Areas.AdminOrganista.ViewComponents
{
    public class MessageCounterComponent:ViewComponent
    {
        private readonly AppDbContext db;

        public MessageCounterComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var message = db.MessageFromPages.ToList();

            return View(await Task.FromResult(message));
        }
    }
}
