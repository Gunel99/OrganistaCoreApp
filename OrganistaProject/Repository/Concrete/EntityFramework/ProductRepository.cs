using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext _db) : base(_db)
        {
        }

        public AppDbContext AppDbContext
        {
            get { return _db as AppDbContext; }
        }
        
        public List<Product> GetTopProducts()
        {
            return AppDbContext.Products.OrderByDescending(p => p.Id).Take(3).ToList();
        }

        public void UpdateProduct(Product entity)
        {
            var product = Get(entity.Id);

            if (product != null)
            {
                product.Name = entity.Name;
                product.Image = entity.Image;
                product.Description = entity.Description;
                product.Price = entity.Price;
                product.CategoryId = entity.CategoryId;
                product.DateAdded = DateTime.Now;
                product.HtmlContent = entity.HtmlContent;
                product.IsApproved = entity.IsApproved;
                product.IsHome = entity.IsHome;
                product.IsFeatured = entity.IsFeatured;

                _db.SaveChanges();
            }
            _db.SaveChanges();
        }

    }
}
