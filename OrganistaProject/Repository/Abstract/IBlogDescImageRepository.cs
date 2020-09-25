using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Abstract
{
    public interface IBlogDescImageRepository
    {
        BlogDescImage GetById(int id);
        IQueryable<BlogDescImage> GetAll();
        void AddBlogDescImage(BlogDescImage entity);
        void UpdateBlogDescImage(BlogDescImage entity);
        void DeleteBlogDescImage(int id);
    }
}
