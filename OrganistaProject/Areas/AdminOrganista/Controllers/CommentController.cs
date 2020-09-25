using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Entity;

namespace OrganistaProject.Areas.AdminOrganista.Controllers
{
    [Area("AdminOrganista")]
    [Authorize(Roles = "Admin")]
    public class CommentController : Controller
    {
        private readonly AppDbContext db;

        public CommentController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.CommentFromPages.ToList());
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            CommentFromPage comment = db.CommentFromPages.FirstOrDefault(c => c.Id == id);
            if (comment == null) return NotFound();
            comment.IsRead = true;
            db.SaveChanges();
            return View(comment);
        }

        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(int id, ClientComment clientComment)
        {
            if (ModelState.IsValid)
            {
                string email = db.CommentFromPages.FirstOrDefault(c => c.Id == id).Email;
                clientComment.Email = email;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("oforganista@gmail.com", "Organista");
                mail.To.Add(new MailAddress(clientComment.Email));

                mail.Subject = clientComment.Subject;
                mail.Body = clientComment.Message;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("oforganista@gmail.com", "Organista123");
                db.CommentFromPages.FirstOrDefault(c => c.Id == id).IsResponsed = true;
                db.SaveChanges();
                smtp.Send(mail);
                TempData["message"] = $"Message has sent to {clientComment.Email} ";

                return RedirectToAction(nameof(Index));
            }
            return View(clientComment);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var findComment = db.CommentFromPages.FirstOrDefault(c => c.Id == id);

            if (findComment == null)
            {
                return NotFound();
            }

            db.CommentFromPages.Remove(findComment);
            db.SaveChanges();

            TempData["message"] = $"{findComment.Email} has been deleted.";
            return RedirectToAction("Index", "Comment");
        }
    }
}