using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class BlogComponent:ViewComponent
    {
        private IBlogRepository repo;

        public BlogComponent(IBlogRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repo.GetAll().Where(b => b.IsApproved).Take(3).ToList());
        }
    }
}
