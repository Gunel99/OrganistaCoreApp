using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;

namespace OrganistaProject.Controllers
{
    public class ContactController : Controller
    {
        private IPasswordHasher<AppUser> passwordHasher;
        private UserManager<AppUser> userManager;
        private readonly AppDbContext db;

        public ContactController(IPasswordHasher<AppUser> _passwordHasher, UserManager<AppUser> _userManager, AppDbContext _db)
        {
            passwordHasher = _passwordHasher;
            userManager = _userManager;
            db = _db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
                

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MessageFromPage client)
        {
            if (ModelState.IsValid)
            {
                db.MessageFromPages.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(client);
        }
    }
}