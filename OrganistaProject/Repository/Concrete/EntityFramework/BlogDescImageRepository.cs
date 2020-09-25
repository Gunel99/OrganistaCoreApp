using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class BlogDescImageRepository : IBlogDescImageRepository
    {
        private readonly AppDbContext context;
        public BlogDescImageRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void AddBlogDescImage(BlogDescImage entity)
        {
            context.BlogDescImages.Add(entity);
            context.SaveChanges();
        }

        public void DeleteBlogDescImage(int id)
        {
            var image = context.BlogDescImages.FirstOrDefault(i => i.Id == id);
            if(image != null)
            {
                context.BlogDescImages.Remove(image);
                context.SaveChanges();
            }
        }

        public IQueryable<BlogDescImage> GetAll()
        {
            return context.BlogDescImages;
        }

        public BlogDescImage GetById(int id)
        {
            return context.BlogDescImages.FirstOrDefault(i => i.Id == id);
        }

        public void UpdateBlogDescImage(BlogDescImage entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
