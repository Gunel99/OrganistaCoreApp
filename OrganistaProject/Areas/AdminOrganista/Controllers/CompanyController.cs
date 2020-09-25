using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class CompanyController : Controller
    {
        private readonly AppDbContext db;

        public CompanyController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.Companies.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Company entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                db.Companies.Add(entity);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(db.Companies.FirstOrDefault(c=>c.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Company entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                db.Companies.Update(entity);
                db.SaveChanges();
                TempData["message"] = $"{entity.Name} yenilendi.";
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            db.Companies.Remove(db.Companies.FirstOrDefault(c => c.Id == id));
            db.SaveChanges();
            TempData["message"] = $"{id} has been deleted.";
            return RedirectToAction("Index", "Company");
        }
    }
}