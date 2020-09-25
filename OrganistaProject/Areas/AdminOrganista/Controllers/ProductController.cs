using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private IUnitOfWork unitRepo;

        public ProductController(IUnitOfWork _unitRepo)
        {
            unitRepo = _unitRepo;
        }

        public IActionResult Index()
        {
            return View(unitRepo.Products.GetAll().ToList());
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            Product product = unitRepo.Products.Get((int)id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(unitRepo.Categories.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;
                entity.DateAdded = DateTime.Now;

                unitRepo.Products.Add(entity);
                unitRepo.Products.Save();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(unitRepo.Categories.GetAll(), "Id", "Name");
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(unitRepo.Categories.GetAll(), "Id", "Name");

            return View(unitRepo.Products.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product entity, IFormFile file)
        {
                if (ModelState.IsValid)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    
                    entity.Image = file.FileName;
                    entity.DateAdded = DateTime.Now;

                    unitRepo.Products.UpdateProduct(entity);
                    TempData["message"] = $"{entity.Name} yenilendi.";
                    return RedirectToAction("Index");
                }

                ViewBag.Categories = new SelectList(unitRepo.Categories.GetAll(), "Id", "Name");

                return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(Product entity)
        {
            unitRepo.Products.Delete(entity);
            TempData["message"] = $"{entity.Id} has been deleted.";
            unitRepo.Products.Save();
           
            return RedirectToAction("Index", "Product");
        }

    }
}