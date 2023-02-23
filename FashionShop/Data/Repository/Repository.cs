using FashionShop.Data.Configuration;
using FashionShop.Data.IRepository;
using FashionShop.Domin.Common;
using FashionShop.Domin.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FashionShop.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private string path;
        private List<TEntity> entities = new List<TEntity>();

        public Repository()
        {
            if(typeof(TEntity) == typeof(User))
            {
                path = Constans.USER_PATH;
            }
            else if(typeof(TEntity) == typeof(Product))
            {
                path = Constans.PRODUC_PATH;
            }
        }
        public async Task<TEntity> CreatAsync(TEntity value)
        {
            var entities = await GetAllAsync();
            if(entities.Count == 0)
            {
                value.Id = 0;
            }
            else
            {
                value.Id += entities[entities.Count -1].Id + 1;
            }
            value.created_at = DateTime.UtcNow;
            entities.Add(value);
            string jsonmodul = JsonConvert.SerializeObject(entities);
            Console.WriteLine(jsonmodul);
            File.WriteAllText(path, jsonmodul);
            return value;
        }

        public async Task<bool> DelateAsync(Predicate<TEntity> predicate)
        {
            entities = await GetAllAsync();

            TEntity entity = await GetAsync(x => predicate(x));
            if(entity == null)
                return false;

            entities.Remove(entity);
            string Jsonmodul = JsonConvert.SerializeObject(entities);
            File.WriteAllText(path, Jsonmodul);

            return true;
        }

        public async Task<TEntity> GetAsync(Predicate<TEntity> predicate)
        {
            var entity = await GetAllAsync();
            if(entity == null)
                return null;
            return entities.FirstOrDefault(x => predicate(x));
        }

        public async Task<List<TEntity>> GetAllAsync(Predicate<TEntity> predicate = null)
        {
            string model = await File.ReadAllTextAsync(path);
            if(model.Length == 0)
            {
                await File.WriteAllTextAsync(path, "[]");
                model = "[]";
            }

            entities = JsonConvert.DeserializeObject<List<TEntity>>(model);   
            if(predicate is not null)
            {
                var res = entities.FindAll(x => predicate(x));
                return res;
            }
            return entities;
        }

        public async Task<TEntity> UpdateAsync(List<TEntity> entities, TEntity value)
        {

            var valuejson = JsonConvert.SerializeObject(entities);
            Console.WriteLine("update : " + valuejson.ToString());
            var json = File.ReadAllTextAsync(path).ToString();
            Console.WriteLine(json.ToString());
            await File.WriteAllTextAsync(path, valuejson);

            return value;

        }
    }
}
