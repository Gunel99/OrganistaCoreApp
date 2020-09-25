using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private IUnitOfWork unitRepo;

        public CategoryController(IUnitOfWork _unitRepo)
        {
            unitRepo = _unitRepo;
        }
        
        public IActionResult Index()
        {
            return View(unitRepo.Categories.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category entity)
        {
            bool IsValid = unitRepo.Categories.GetAll().Any(c => c.Name.ToLower() == entity.Name);

            if (ModelState.IsValid)
            {
                if (!IsValid)
                {
                    unitRepo.Categories.Add(entity);
                    unitRepo.SaveChanges();
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Bu adda category artiq movcuddur!");
            }
            
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entity = unitRepo.Categories.GetAll()
                        .Include(c => c.Products)
                        .Where(c => c.Id == id).FirstOrDefault();

            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitRepo.Categories.Edit(entity);
                unitRepo.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var findProduct = unitRepo.Categories.Get(id);

            if (findProduct == null)
            {
                return NotFound();
            }
            
            unitRepo.Categories.Delete(findProduct);
            unitRepo.SaveChanges();
            TempData["message"] = $"{findProduct.Name} has been deleted.";
            return RedirectToAction("Index", "Category");
        }
    }
}