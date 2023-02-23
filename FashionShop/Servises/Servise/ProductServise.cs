using FashionShop.Data.Repository;
using FashionShop.Domin.Entities;
using FashionShop.Servises.Helper;
using FashionShop.Servises.Interfaces;


namespace FashionShop.Servises.Servise
{
    public class ProductServise : IProductServise
    {
        private readonly Repository<Product> productrepository = new Repository<Product>();
        public async Task<Response<Product>> AddAsync(Product product)
        {
            await productrepository.CreatAsync(product);
            return new Response<Product>
            {
                StatusCode = 200,
                Message = "ok",
                Result = product
            };
        }

        public async Task<Response<bool>> DeleteAsync(long id)
        {
            var model = await productrepository.GetAsync(x => x.Id == id);
            if(model == null)
                return new Response<bool>
                {
                    Result = false,
                };

            await productrepository.DelateAsync(p => p.Id == id);

            return new Response<bool>
            {
                StatusCode = 200,
                Message = "ok",
                Result = true,
            };
        }

        public async Task<Response<List<Product>>> GetAllAsync(Predicate<Product> predicate = null)
        {
            var model = await productrepository.GetAllAsync(p => predicate(p));
            return new Response<List<Product>>
            {
                StatusCode = 200,
                Message = "ok",
                Result = model
            };
        }

        public async Task<Response<Product>> GetByIsAsync(long id)
        {
            var entitirs = await productrepository.GetAllAsync();
            var product = entitirs.FirstOrDefault(p => p.Id == id);
            if (product is null)
                return new Response<Product>();
            return new Response<Product>
            {
                StatusCode = 200,
                Message = "Ok",
                Result = product
            };
        }

        public async Task<Response<Product>> UpdateAsync(long id, Product product)
        {
            var model = await productrepository.GetAsync(p => p.Id == id);
            if (model is null)
                return new Response<Product>();
            await productrepository.UpdateAsync(model);

            return new Response<Product>
            {
                StatusCode = 200,
                Message = "ok",
                Result = model
            };
        }
    }
}
