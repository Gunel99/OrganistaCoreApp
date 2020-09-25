using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository repo;
        private IUnitOfWork unit;
        private readonly AppDbContext db;
        public HomeController(IProductRepository _repo, IUnitOfWork _unit, AppDbContext _db)
        {
            repo = _repo;
            unit = _unit;
            db = _db;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Index(MessageFromPage client)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.MessageFromPages.Add(client);
        //        db.SaveChanges();
        //        return RedirectToAction("Index", "Home");
        //    }

        //    return View(client);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmailAndContactUsModel model)
        {
            if (model.MessageFromPage == null)
            {
                if (ModelState.IsValid)
                {
                    db.Newsletters.Add(model.Newsletter);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }

            if(model.Newsletter == null)
            {
                if (ModelState.IsValid)
                {
                    db.MessageFromPages.Add(model.MessageFromPage);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }
    }
}