using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class AuthorController : Controller
    {
        private IAuthorRepository _authorRepo;

        public AuthorController(IAuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public IActionResult Index()
        {
            return View(_authorRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);
                
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                
                entity.Image = file.FileName;
                entity.PostedDate = DateTime.Now;

                _authorRepo.AddAuthor(entity);
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_authorRepo.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Author entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;
                entity.PostedDate = DateTime.Now;

                _authorRepo.UpdateAuthor(entity);
                TempData["message"] = $"{entity.Fullname} yenilendi.";
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _authorRepo.DeleteAuthor(id);
            TempData["message"] = $"{id} has been deleted.";
            return RedirectToAction("Index", "Author");
        }
    }
}