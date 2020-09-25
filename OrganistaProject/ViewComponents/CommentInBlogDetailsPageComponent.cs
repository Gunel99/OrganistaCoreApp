using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class CommentInBlogDetailsPageComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public CommentInBlogDetailsPageComponent(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var comments = db.CommentFromPages.ToList();
            return View(await Task.FromResult(comments));
        }
    }
}
