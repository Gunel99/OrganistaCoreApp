using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext context;
        public BlogRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void AddBlog(Blog entity)
        {
            context.Blogs.Add(entity);
            context.SaveChanges();
        }

        public void DeleteBlog(int id)
        {
            var blog = context.Blogs.FirstOrDefault(b => b.Id == id);
            if (blog != null)
            {
                context.Blogs.Remove(blog);
                context.SaveChanges();
            }
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public Blog GetById(int id)
        {
            return context.Blogs.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBlog(Blog entity)
        {
            var blog = GetById(entity.Id);

            if(blog != null)
            {
                blog.Name = entity.Name;
                blog.Image = entity.Image;
                blog.Description = entity.Description;
                blog.AuthorId = entity.AuthorId;
                blog.BlogDescImageId = entity.BlogDescImageId;
                blog.BoldSentence = entity.BoldSentence;
                blog.IsApproved = entity.IsApproved;
                blog.IsHome = entity.IsHome;

                context.SaveChanges();
            }
            context.SaveChanges();
        }
    }
}
