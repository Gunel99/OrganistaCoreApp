using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext db;

        public OrderController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.Orders.ToList());
        }

        public async Task<IActionResult> Info(int? id)
        {
            if (id == null) return NotFound();

            Order entity = await db.Orders.Include(o => o.OrderLines).ThenInclude(ol => ol.Product).Where(o=>o.Id == id).SingleOrDefaultAsync();
            return View(entity);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            Order entity = await db.Orders.Include(o => o.OrderLines).ThenInclude(ol => ol.Product).Where(o => o.Id == id).SingleOrDefaultAsync();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Order entity)
        {
            if (ModelState.IsValid)
            {
                entity.OrderState = EnumOrderState.Completed;
                
                db.Orders.Update(entity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var entity = db.OrderLines.Include(o => o.Order).FirstOrDefault(o => o.Id == id);
            int orderId = entity.OrderId;
            double orderPrice = entity.Price;

            db.OrderLines.Remove(entity);
            TempData["message"] = $"{id} product order has been deleted.";
            entity.Order.Total = entity.Order.Total - orderPrice;
            db.SaveChanges();

            return RedirectToAction("Edit" + "/" + orderId, "Order");
        }

        [HttpPost]
        public IActionResult Delete(Order entity)
        {
            db.Orders.Remove(entity);
            TempData["message"] = $"{entity.Id} order has been deleted.";
            db.SaveChanges();

            return RedirectToAction("Index", "Order");
        }

    }
}