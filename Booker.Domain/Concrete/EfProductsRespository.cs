using Booker.Domain.Concrete;
using Booker.Domain.Entities;
using Booker.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Domain.Concrete
{
    public class EfProductsRespository : IProductsRepository
    {
        private EfDbContext context = new EfDbContext();

        public IQueryable<Product> Products
        {
            get 
            { 
                return context.Products; 
            }
        }

        public Product GetProduct(int id)
        {
            return Products.SingleOrDefault(x => x.Id == id);
        }

        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                var dbProduct = context.Products.Find(product.Id);
                if (dbProduct != null)
                {
                    dbProduct.Title = product.Title;
                }
            }

            context.SaveChanges();
        }

        public Product DeleteProduct(int productID)
        {
            var dbProduct = context.Products.Find(productID);
            if (dbProduct != null)
            {
                dbProduct.Active = false;
                context.SaveChanges();
            }

            return dbProduct;
        }
    }
}
