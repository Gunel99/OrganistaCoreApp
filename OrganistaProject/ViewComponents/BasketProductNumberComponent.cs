using Microsoft.AspNetCore.Mvc;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.ViewComponents
{
    public class BasketProductNumberComponent:ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJson<Cart>("Cart")?.Products.Count().ToString() ?? "0";
        }


    }
}
