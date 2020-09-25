using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrganistaProject.DAL;
using OrganistaProject.Models;

namespace OrganistaProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext db;
        public AboutController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            AboutModel model = new AboutModel
            {
                AboutUsFirstDesc = db.AboutUsFirstDescs.FirstOrDefault(),
                AboutUsSecondDesc = db.AboutUsSecondDescs.FirstOrDefault()
            };

            return View(model);
        }
    }
}