using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class FreshArrivalComponent : ViewComponent
    {
        private IProductRepository repo;

        public FreshArrivalComponent(IProductRepository _repo)
        {
            repo = _repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repo.GetAll().Where(p => p.IsApproved && p.IsHome).ToList());
        }
    }
}
