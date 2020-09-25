using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Controllers
{
    public class BlogController : Controller
    {
        public int PageSize = 3;
        private IBlogRepository blogRepository;
        private readonly AppDbContext db;
        public BlogController(IBlogRepository _blogRepository, AppDbContext _db)
        {
            blogRepository = _blogRepository;
            db = _db;
        }

        public IActionResult Index(int page = 1)
        {
            var blogs = blogRepository.GetAll().Where(b=>b.IsApproved);

            ViewBag.BlogCount = blogs.Count();
            ViewBag.PageCount = Math.Ceiling((decimal)ViewBag.BlogCount / PageSize);
            ViewBag.Page = page;

            blogs = blogs.Skip((page - 1) * PageSize).Take(PageSize);

            blogs = blogs.Include(b => b.Author).OrderByDescending(b => b.Author.PostedDate);

            return View(blogs);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var blogs = blogRepository.GetAll();

            return View(blogs.Where(b => b.Id == id).Include(b => b.Author)
            .Include(b => b.BlogDescImage).Select(b => new BlogDetailsModel()
            {
                Blog = b,
                Author = b.Author,
                BlogDescImage = b.BlogDescImage
            }
            ).FirstOrDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(BlogDetailsModel model)
        {
            if (model.CommentFromPage == null)
            {
                if (ModelState.IsValid)
                {
                    db.Newsletters.Add(model.Newsletter);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Blog");
                }
            }

            if (model.Newsletter == null)
            {
                if (ModelState.IsValid)
                {
                    db.CommentFromPages.Add(model.CommentFromPage);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Blog");
                }
            }

            return View(model);
        }

        public IActionResult Search(string search)
        {
            var model = db.Blogs.Where(b => b.Name.Contains(search)).OrderByDescending(b => b.Id).Take(3).ToList();
            return PartialView("_SearchBlogPartial", model);
        }
    }
}