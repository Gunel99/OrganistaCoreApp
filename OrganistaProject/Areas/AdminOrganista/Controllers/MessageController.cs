using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Areas.AdminOrganista.Models;
using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        private readonly AppDbContext db;

        public MessageController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.MessageFromPages.ToList());
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            MessageFromPage message = db.MessageFromPages.FirstOrDefault(m => m.Id == id);
            if (message == null) return NotFound();
            message.IsRead = true;
            db.SaveChanges();
            return View(message);
        }

        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(int id, ClientMessage clientMessage)
        {
            if (ModelState.IsValid)
            {
                string email = db.MessageFromPages.FirstOrDefault(m => m.Id == id).Email;
                clientMessage.Email = email;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("oforganista@gmail.com", "Organista");
                mail.To.Add(new MailAddress(clientMessage.Email));

                mail.Subject = clientMessage.Subject;
                mail.Body = clientMessage.Message;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("oforganista@gmail.com", "Organista123");
                db.MessageFromPages.FirstOrDefault(m => m.Id == id).IsResponsed = true;
                db.SaveChanges();
                smtp.Send(mail);
                TempData["message"] = $"Message has sent to {clientMessage.Email} ";

                return RedirectToAction(nameof(Index));
            }
            return View(clientMessage);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var findMessage = db.MessageFromPages.FirstOrDefault(m => m.Id == id);

            if (findMessage == null)
            {
                return NotFound();
            }

            db.MessageFromPages.Remove(findMessage);
            db.SaveChanges();
            
            TempData["message"] = $"{findMessage.Email} has been deleted.";
            return RedirectToAction("Index", "Message");
        }
    }
}