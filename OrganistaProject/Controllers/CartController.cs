using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;
using OrganistaProject.TagHelpers;

namespace OrganistaProject.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private IUnitOfWork unitRepo;

        public CartController(IUnitOfWork _unitRepo)
        {
            unitRepo = _unitRepo;
        }
                
        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int ProductId, int quantity=1)
        {
            var product = unitRepo.Products.Get(ProductId);

            if(product != null)
            {
                var cart = GetCart();

                cart.AddProduct(product, quantity);

                SaveCart(cart);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int ProductId)
        {
            var product = unitRepo.Products.Get(ProductId);

            if(product != null)
            {
                var cart = GetCart();
                cart.RemoveProduct(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveAllFromCart()
        {
            var cart = GetCart();
            cart.ClearAll();
            SaveCart(cart);
            
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(OrderDetails model)
        {
            var cart = GetCart();

            if(cart.Products.Count == 0)
            {
                ModelState.AddModelError("", "There are not any products");
            }

            if (ModelState.IsValid)
            {
                SaveOrder(cart, model);
                cart.ClearAll();
                SaveCart(cart);
                return View("Completed");
            }
            return View(model);
        }

        private void SaveOrder(Cart cart, OrderDetails details)
        {
            var order = new Order()
            {
                OrderNumber = "A" + (new Random()).Next(11111, 99999).ToString(),
                Total = cart.TotalPrice(),
                OrderDate = DateTime.Now,
                OrderState = EnumOrderState.Waiting,
                Username = User.Identity.Name,
                Address = details.Address,
                City = details.City,
                Country = details.Country,
                PhoneNumber = details.PhoneNumber       
            };

            foreach (var product in cart.Products)
            {
                var orderLine = new OrderLine()
                {
                    Quantity = product.Quantity,
                    Price = product.Product.Price,
                    ProductId = product.Product.Id
                };

                order.OrderLines.Add(orderLine);
            }

            unitRepo.Orders.Add(order);
            unitRepo.SaveChanges();
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        }
    }
}