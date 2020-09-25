using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;

namespace OrganistaProject.Controllers
{
    public class LegalController : Controller
    {
        private readonly AppDbContext db;
        public LegalController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                db.Newsletters.Add(newsletter);
                db.SaveChanges();
                return RedirectToAction("Index", "Legal");
            }

            return View(newsletter);
        }
    }
}