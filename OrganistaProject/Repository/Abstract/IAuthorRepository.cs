using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Abstract
{
    public interface IAuthorRepository
    {
        Author GetById(int id);
        IQueryable<Author> GetAll();
        void AddAuthor(Author entity);
        void UpdateAuthor(Author entity);
        void DeleteAuthor(int id);
    }
}
