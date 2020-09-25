using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class EmailAndContactUsModel
    {
        public Newsletter Newsletter { get; set; }
        public MessageFromPage MessageFromPage { get; set; }
    }
}
