using Booker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Domain.Interfaces
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }

        Product GetProduct(int id);

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
