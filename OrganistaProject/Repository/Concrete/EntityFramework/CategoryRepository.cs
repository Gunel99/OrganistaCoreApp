using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Models;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext _db) : base(_db)
        {
        }

        public AppDbContext AppDbContext
        {
            get { return _db as AppDbContext; }
        }

        public IEnumerable<CategoryModel> GetAllForProductCount()
        {
            return GetAll().Select(c => new CategoryModel()
            {
                Id = c.Id,
                Name = c.Name,
                Count = c.Products.Count()
            });
        }

        public Category GetByName(string name)
        {
            return AppDbContext.Categories.Where(c => c.Name == name).FirstOrDefault();
        }
    }
}
