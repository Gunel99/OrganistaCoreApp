using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment env;

        public SliderController(AppDbContext _db, IHostingEnvironment _env)
        {
            db = _db;
            env = _env;
        }

        public IActionResult Index()
        {
            ViewBag.SliderCount = db.Sliders.Count();
            return View(db.Sliders.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                db.Sliders.Add(entity);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
           
            return View(entity);
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            db.Sliders.Remove(db.Sliders.FirstOrDefault(s=>s.Id == id));
            db.SaveChanges();
            TempData["message"] = $"{id} has been deleted.";
            return RedirectToAction("Index", "Slider");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(db.Sliders.FirstOrDefault(s=>s.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Slider entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;
                db.Sliders.Update(entity);
                db.SaveChanges();
                TempData["message"] = $"{entity.Title} yenilendi.";
                return RedirectToAction("Index");
            }

            return View(entity);
        }
    }
}