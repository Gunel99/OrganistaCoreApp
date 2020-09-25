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
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class ImageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private IBlogDescImageRepository _repo;

        public ImageController(AppDbContext db, IHostingEnvironment env, IBlogDescImageRepository repo)
        {
            _db = db;
            _env = env;
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_db.BlogDescImages.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogDescImage photo)
        {
            if (photo.Files == null || photo.Files.Length == 0)
            {
                ModelState.AddModelError("Files", "Please, select at least 1 file!");
                return View();
            }

            foreach (IFormFile img in photo.Files)
            {
                if (!img.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Files", "You do not have an access for adding different type of file!");
                    return View();
                }

                var imgSave = Path.Combine(_env.WebRootPath, "img");
                var fileName = Guid.NewGuid().ToString() + img.FileName;
                var path = Path.Combine(imgSave, fileName);
                FileStream fileStream = new FileStream(path, FileMode.Create);

                await img.CopyToAsync(fileStream);

                BlogDescImage newPhoto = new BlogDescImage { Image = fileName };

                await _db.AddAsync(newPhoto);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var findProduct = _repo.GetById(id);
            _repo.DeleteBlogDescImage(id);
            TempData["message"] = $"{findProduct.Image} has been deleted.";
            return RedirectToAction("Index", "Image");
        }
    }
}