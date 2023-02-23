using FashionShop.Domin.Entities;
using FashionShop.Servises.Interfaces;
using FashionShop.Servises.Helper;
using FashionShop.Data.IRepository;
using FashionShop.Data.Repository;

namespace FashionShop.Servises.Servise
{
    public class UserServise : IUserServise
    {
        private readonly IRepository<User> repositoryservise = new Repository<User>();
        public async Task<Response<User>> CreatAsync(User user)
        {
            var model = await repositoryservise.GetAsync(x => x.UserName == user.UserName
            || x.Email.ToLower() == user.Email.ToLower()
            || x.PhoneNumber == user.PhoneNumber);
            if (model != null)
            {
                return new Response<User>()
                {
                    Message = "User already created"
                };
            }
            var res = await repositoryservise.CreatAsync(user);
            return new Response<User>()
            {
                StatusCode = 201,
                Message = "Created",
                Result = res
            };
        }

        public async Task<Response<bool>> DeleateAsync(long id)
        {
            var model = await repositoryservise.GetAsync(p => p.Id == id);
            if (model is not null)
            {
                return new Response<bool>
                {
                    Message = "User not found",
                    Result = false
                };
            }

            await repositoryservise.DelateAsync(x => x.Id == id);
            return new Response<bool>
            {
                StatusCode = 200,
                Message = "ok",
                Result = true
            };
        }

        public async Task<Response<List<User>>> GetAllAsync(Predicate<User> predicate = null)
        {
            var res = await repositoryservise.GetAllAsync(x => predicate(x));
            return new Response<List<User>>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = res
            };
        }

        public async Task<Response<User>> GetByIdAsync(long id)
        {
            var entities = await repositoryservise.GetAllAsync();
            var modul = entities.FirstOrDefault(p => p.Id == id);
            if (modul is null)
                return new Response<User>();
                
            return new Response<User>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = modul
            };
        }

        public async Task<Response<User>> GetByNameAsync(string name)
        {
            var entities = await repositoryservise.GetAllAsync();
            var model = entities.FirstOrDefault(x => x.FirstName == name);
            if (model is null)
                return new Response<User>();

            return new Response<User>()
            {
                StatusCode = 200,
                Message = "ok",
                Result = model
            };
        }

        public async Task<Response<User>> UpdatAsync(long id, User user)
        {
            var entities = await repositoryservise.GetAllAsync();
            var model = entities.FirstOrDefault(u => u.Id == id);
            if (model is null)
                return new Response<User>();
            return new Response<User>()
            {
                StatusCode = 201,
                Message = "ok",
                Result = model
            };
        }        
    }
}
