using FashionShop.Domin.Entities;
using System;
using FashionShop.Servises.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Servises.Interfaces
{
    public interface IProductServise
    {
        public Task<Response<Product>> AddAsync(Product product);
        public Task<Response<Product>> UpdateAsync(long id, Product product);
        public Task<Response<bool>> DeleteAsync(long id);
        public Task<Response<Product>> GetByIsAsync(long id);
        public Task<Response<List<Product>>> GetAllAsync(Predicate<Product> predicate = null);

    }
}
