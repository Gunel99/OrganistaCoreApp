using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class BlogDescImageComponent:ViewComponent
    {
        private IBlogDescImageRepository repo;

        public BlogDescImageComponent(IBlogDescImageRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repo.GetAll().Take(2).ToList());
        }
    }
}
