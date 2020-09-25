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
    public class FollowImageController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public FollowImageController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_db.FollowImages.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FollowImage photo)
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

                FollowImage newPhoto = new FollowImage { Image = fileName };
             
                await _db.AddAsync(newPhoto);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var findProduct = _db.FollowImages.FirstOrDefault(f => f.Id == id);
            _db.FollowImages.Remove(findProduct);
            _db.SaveChanges();
            TempData["message"] = $"{findProduct.Image} has been deleted.";
            return RedirectToAction("Index", "FollowImage");
        }
    }
}