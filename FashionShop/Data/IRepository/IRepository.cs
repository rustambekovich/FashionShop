using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Data.IRepository
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> CreatAsync(TEntity value);
        Task<TEntity> UpdateAsync(List<TEntity> entities, TEntity entity);
        Task<TEntity> GetAsync(Predicate<TEntity> predicate);
        Task<List<TEntity>> GetAllAsync(Predicate<TEntity> predicate = null);
        Task<bool> DelateAsync(Predicate<TEntity> predicate);

    }
}
