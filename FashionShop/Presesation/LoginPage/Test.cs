using FashionShop.Domin.Entities;
using FashionShop.Domin.Enums;
using FashionShop.Servises.Interfaces;
using FashionShop.Servises.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Presesation.LoginPage
{
    public class Test
    {
        private IUserServise userservise = new UserServise();
        private IProductServise productServise = new ProductServise();
        /*public async Task<User> TestUser()
        {


            User user = new User();
            user.FirstName = "0";
            user.UserName = "0";
            user.Data_of_bithday = "0";
            user.PhoneNumber = "0";
            user.created_at = DateTime.UtcNow;
            user.updated_at = DateTime.UtcNow;
            user.Email = "0";
            user.genter_type = Gender.male;
            user.LastName = "0";
            user.Password = "0";
            Console.WriteLine(user.FirstName);
            await userservise.CreatAsync(user);


            *//*await userservise.UpdatAsync(1, user);*/

        /*var res = await userservise.GetByIdAsync(0);
         * 
        Console.WriteLine(res.Result.LastName);*/
        /*var res = await userservise.GetAllAsync();
        foreach (var us in res.Result)
        {
            Console.WriteLine(us.FirstName);
            Console.WriteLine(us.LastName);

        }*/

        /*await userservise.DeleateAsync(1);*//*


        return null;
    }*/



       /* public async Task<Product> TestProduct()
        {
            Product product = new Product();
            product.description = "shim";
            product.Name = "Test";
            product.Clothes = ProductCatigory.shirt;
            product.created_at = DateTime.UtcNow;
            product.Color = "qora";

           await productServise.CreatAsync(product);
            
            return product;
        }*/


    }
}
