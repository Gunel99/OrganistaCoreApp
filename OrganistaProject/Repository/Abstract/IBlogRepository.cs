using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Abstract
{
    public interface IBlogRepository
    {
        Blog GetById(int id);
        IQueryable<Blog> GetAll();
        void AddBlog(Blog entity);
        void UpdateBlog(Blog entity);
        void DeleteBlog(int id);
    }
}
