using OrganistaProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetTopProducts();
        void UpdateProduct(Product entity);
    }
}
