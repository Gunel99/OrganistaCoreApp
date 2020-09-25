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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext db;
        private readonly IHostingEnvironment env;

        public TestimonialController(AppDbContext _db, IHostingEnvironment _env)
        {
            db = _db;
            env = _env;
        }

        public IActionResult Index()
        {
            return View(db.Testimonials.ToList());
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            Testimonial testimonial = db.Testimonials.FirstOrDefault(t => t.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Testimonial entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                db.Testimonials.Add(entity);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(db.Testimonials.FirstOrDefault(t => t.Id == id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Testimonial entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                db.Testimonials.Update(entity);
                db.SaveChanges();

                TempData["message"] = $"{entity.Name} yenilendi.";
                return RedirectToAction("Index");
            }
           
            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            db.Testimonials.Remove(db.Testimonials.FirstOrDefault(s => s.Id == id));
            db.SaveChanges();
            TempData["message"] = $"{id} has been deleted.";
            return RedirectToAction("Index", "Testimonial");
        }
    }
}