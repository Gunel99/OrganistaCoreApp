using OrganistaProject.Entity;
using OrganistaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetByName(string name);

        IEnumerable<CategoryModel> GetAllForProductCount();
    }
}
