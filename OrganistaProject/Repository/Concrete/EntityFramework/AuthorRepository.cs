using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext context;
        public AuthorRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void AddAuthor(Author entity)
        {
            context.Authors.Add(entity);
            context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var author = context.Authors.FirstOrDefault(i => i.Id == id);
            if (author != null)
            {
                context.Authors.Remove(author);
                context.SaveChanges();
            }
        }

        public IQueryable<Author> GetAll()
        {
            return context.Authors;
        }

        public Author GetById(int id)
        {
            return context.Authors.FirstOrDefault(i => i.Id == id);
        }

        public void UpdateAuthor(Author entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
