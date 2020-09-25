using OrganistaProject.DAL;
using OrganistaProject.Entity;
using OrganistaProject.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Repository.Concrete.EntityFramework
{
    public class OrderRepository:GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context):base(context)
        {
        }
    }
}
