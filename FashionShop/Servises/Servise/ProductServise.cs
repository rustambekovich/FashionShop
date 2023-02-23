using FashionShop.Data.Repository;
using FashionShop.Domin.Entities;
using FashionShop.Servises.Helper;
using FashionShop.Servises.Interfaces;


namespace FashionShop.Servises.Servise
{
    /*public class ProductServise : IProductServise
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
            //await productrepository.UpdateAsync(entities);

            return new Response<Product>
            {
                StatusCode = 200,
                Message = "ok",
                Result = model
            };
        }
    }*/
    public class ProductServise : IProductServise
    {
        private readonly Repository<Product> productrepository = new Repository<Product>();
        public async Task<Response<Product>> CreatAsync(Product product)
        {
            var model = await productrepository.GetAsync(x => x.Name == product.Name);
            if (model != null)
            {
                return new Response<Product>()
                {
                    Message = "User already created"
                };
            }
            var res = await productrepository.CreatAsync(product);
            return new Response<Product>()
            {
                StatusCode = 201,
                Message = "Created",
                Result = res
            };
        }

        public async Task<Response<bool>> DeleateAsync(long id)
        {
            var model = await productrepository.GetAsync(p => p.Id == id);
            if (model is null)
            {
                return new Response<bool>
                {
                    Message = "User not found",
                    Result = false
                };
            }

            await productrepository.DelateAsync(x => x.Id == id);
            return new Response<bool>
            {
                StatusCode = 200,
                Message = "ok",
                Result = true
            };
        }

        public async Task<Response<List<Product>>> GetAllAsync(Predicate<Product> predicate = null)
        {
            var res = await productrepository.GetAllAsync(predicate);
            return new Response<List<Product>>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = res
            };
        }

        public async Task<Response<Product>> GetByIdAsync(long id)
        {
            var entities = await productrepository.GetAllAsync();
            var modul = entities.FirstOrDefault(p => p.Id == id);
            if (modul is null)
                return new Response<Product>();

            return new Response<Product>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = modul
            };
        }

        public async Task<Response<Product>> GetByNameAsync(string name)
        {
            var entities = await productrepository.GetAllAsync();
            var model = entities.FirstOrDefault(x => x.FirstName == name);
            if (model is null)
                return new Response<Product>();

            return new Response<Product>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = model
            };
        }

        public async Task<Response<Product>> UpdatAsync(long id, Product product)
        {
            var entities = await productrepository.GetAllAsync();
            var model = entities.FirstOrDefault(u => u.Id == id);
            if (model is null)
                return new Response<Product>();
            Console.WriteLine("ok2");
            model.Id = id;
            model.PhoneNumber = user.PhoneNumber;
            model.UserName = user.UserName;
            model.Email = user.Email;
            model.Password = user.Password;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.updated_at = DateTime.Now;
            model.created_at = user.created_at;

            var res = await productrepository.UpdateAsync(entities, model);

            return new Response<Product>()
            {
                StatusCode = 201,
                Message = "ok",
                Result = res
            };
        }
    }
}
