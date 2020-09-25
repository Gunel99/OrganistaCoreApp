using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Areas.AdminOrganista.ViewComponents
{
    public class CommentCounterComponent:ViewComponent
    {
        private readonly AppDbContext db;

        public CommentCounterComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var comment = db.CommentFromPages.ToList();

            return View(await Task.FromResult(comment));
        }
    }
}
