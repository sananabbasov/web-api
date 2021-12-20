using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product, GiftDbContext>, IProductRepository
    {
        public List<Product> GetPolularProducts()
        {
            using (var context = new GiftDbContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
