using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class BlogListForHomePageComponent:ViewComponent
    {
        private IBlogRepository repo;

        public BlogListForHomePageComponent(IBlogRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repo.GetAll().Include(b=>b.Author).Where(b => b.IsApproved && b.IsHome).Take(3).ToList());
        }
    }
}
