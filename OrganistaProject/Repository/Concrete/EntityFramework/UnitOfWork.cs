using OrganistaProject.DAL;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db ?? throw new ArgumentNullException("DbContext can not the empty!");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;
        private IOrderRepository _orders;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new ProductRepository(_db));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new CategoryRepository(_db));
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return _orders ?? (_orders = new OrderRepository(_db));
            }
        }

        public int SaveChanges()
        {
            try
            {
                return _db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
