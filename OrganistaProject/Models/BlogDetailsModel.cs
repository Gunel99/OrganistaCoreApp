using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Models
{
    public class BlogDetailsModel
    {
        public Blog Blog { get; set; }
        public Author Author { get; set; }
        public BlogDescImage BlogDescImage { get; set; }
        public CommentFromPage CommentFromPage { get; set; }
        public Newsletter Newsletter { get; set; }

    }
}
