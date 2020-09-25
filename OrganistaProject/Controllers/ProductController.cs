using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.DAL;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;

namespace OrganistaProject.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 3;
        private IProductRepository repo;
        private readonly AppDbContext db;

        public ProductController(IProductRepository _repo, AppDbContext _db)
        {
            repo = _repo;
            db = _db;
        }

        public IActionResult Index(string category, int page = 1)
        {
            var products = repo.GetAll();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(p => p.Category)
                    .Where(p => p.Category.Name == category);
            }

            ViewBag.Category = category;
            ViewBag.ProductCount = products.Count();
            ViewBag.PageCount = Math.Ceiling((decimal)ViewBag.ProductCount / PageSize);
            ViewBag.Page = page;

            products = products.Skip((page - 1) * PageSize).Take(PageSize);
           
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var products = repo.GetAll();

            return View(products.Where(p => p.Id == id).Include(p => p.ProductAttributes)
            .Include(p => p.Category).Select(p => new ProductDetailsModel()
            {
                Product = p,
                ProductAttributes = p.ProductAttributes,
                Category = p.Category
            }
            ).FirstOrDefault());
        }

        [HttpPost]

        public IActionResult Details(ProductDetailsModel model)
        {
            if (ModelState.IsValid)
            {
                db.CommentFromPages.Add(model.CommentFromPage);
                db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }

            return View(model.CommentFromPage);
        }

        public IActionResult Search(string search)
        {
            var model = db.Products.Where(p => p.Name.Contains(search)).OrderByDescending(p => p.Id).Take(3).ToList();
            return PartialView("_SearchProductPartial", model);
        }
    }
}