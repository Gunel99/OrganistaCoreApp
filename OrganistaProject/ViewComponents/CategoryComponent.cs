using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class CategoryComponent:ViewComponent
    {
        private ICategoryRepository repo;
        public CategoryComponent(ICategoryRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repo.GetAllForProductCount());
        }
    }
}
