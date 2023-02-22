using FashionShop.Domin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FashionShop.Servises.Interfaces
{
    public interface IUserServise
    {
        public Task<Response<User>> CreatAsync(User user);

        public Task<Response<User>> GetAllAsync(Predicate<User> predicate = null);
        public Task<Response<User>> GetByIdAsync(long id);
        public Task<Response<User>> GetByNameAsync(string name);
        public Task<Task<bool>> DeleateAsync(long id);
        public Task<Response<User>> UpdatAsync(long id, User user);
    }
}
