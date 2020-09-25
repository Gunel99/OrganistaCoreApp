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
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepo;
        private IAuthorRepository _authorRepo;
        private IBlogDescImageRepository _blogDescrepo;

        public BlogController(IBlogRepository blogRepo, IAuthorRepository authorRepo, IBlogDescImageRepository blogDescrepo)
        {
            _blogRepo = blogRepo;
            _authorRepo = authorRepo;
            _blogDescrepo = blogDescrepo;
        }

        public IActionResult Index()
        {
            return View(_blogRepo.GetAll());
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _blogRepo.GetById((int)id);

            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors = new SelectList(_authorRepo.GetAll(), "Id", "Fullname");
            ViewBag.BlogDesc = new SelectList(_blogDescrepo.GetAll(), "Id", "Image");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;

                _blogRepo.AddBlog(entity);

                return RedirectToAction("Index");
            }
            ViewBag.Authors = new SelectList(_authorRepo.GetAll(), "Id", "Fullname");
            ViewBag.BlogDesc = new SelectList(_blogDescrepo.GetAll(), "Id", "Image");
            return View(entity);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Authors = new SelectList(_authorRepo.GetAll(), "Id", "Fullname");
            ViewBag.BlogDesc = new SelectList(_blogDescrepo.GetAll(), "Id", "Image");
            return View(_blogRepo.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog entity, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                entity.Image = file.FileName;
               
                _blogRepo.UpdateBlog(entity);
                TempData["message"] = $"{entity.Name} yenilendi.";
                return RedirectToAction("Index");
            }
            ViewBag.Authors = new SelectList(_authorRepo.GetAll(), "Id", "Fullname");
            ViewBag.BlogDesc = new SelectList(_blogDescrepo.GetAll(), "Id", "Image");
            return View(entity);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _blogRepo.DeleteBlog(id);
            TempData["message"] = $"{id} has been deleted.";
            return RedirectToAction("Index", "Blog");
        }
    }
}