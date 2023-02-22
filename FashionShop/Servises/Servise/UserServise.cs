using FashionShop.Domin.Entities;
using FashionShop.Servises.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Servises.Servise
{
    public class UserServise : IUserServise
    {
        public Task<Response<User>> CreatAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<Task<bool>> DeleateAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<User>> GetAllAsync(Predicate<User> predicate = null)

        {
            throw new NotImplementedException();
        }

        public Task<Response<User>> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<User>> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Response<User>> UpdatAsync(long id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
