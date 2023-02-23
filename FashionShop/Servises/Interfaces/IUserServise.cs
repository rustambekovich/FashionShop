using FashionShop.Domin.Entities;
using FashionShop.Servises.Helper;
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

        public Task<Response<List<User>>> GetAllAsync(Predicate<User> predicate = null);
        public Task<Response<User>> GetByIdAsync(long id);
        public Task<Response<User>> GetByNameAsync(string name);
        public Task<Response<bool>> DeleateAsync(long id);
        public Task<Response<User>> UpdatAsync(long id, User user);
    }
}
