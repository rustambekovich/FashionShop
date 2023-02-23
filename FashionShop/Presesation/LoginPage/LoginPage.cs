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
    public class LoginPage
    {
        private IUserServise userservise = new UserServise();

        public async Task<User> Loginpage()
        {
            User user = new User();
            user.FirstName = "dfgdf";
            user.UserName = "zdfbdf";
            user.Data_of_bithday = "sdfvfdbv";
            user.PhoneNumber = "1234567890";
            user.created_at = DateTime.Now;
            user.updated_at = DateTime.Now;
            user.Email = "dfbfd";
            user.genter_type = Gender.female;
            user.LastName = "1234567890";   
            user.Password = "1234567890";
            Console.WriteLine(user.FirstName);
            userservise.CreatAsync(user);
            /*while (true)
            {
                User user = new User();
            main:
                Console.WriteLine("\t\tMain menu");
                Console.WriteLine("1.Sign up");
                Console.WriteLine("2.Sign in");
                Console.WriteLine();

                string number = Console.ReadLine();

                if (number == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\tSign up");
                    Console.WriteLine();

                    Console.Write("First name: ");
                    user.FirstName = Console.ReadLine();
                    Console.Write("Last name: ");
                    user.LastName = Console.ReadLine();
                    Console.WriteLine("Choose gender: ");
                    Console.WriteLine("1.Female\n2.Male");
                    string num = Console.ReadLine();

                    Gender role = new Gender();
                    if (num == "1")
                    {
                        role = Gender.female;
                    }
                    else if (num == "2")
                    {
                        role = Gender.male;
                    }
                    Console.Write("Bithday year[dd/mm/yyyy]: ");
                    string bith = Console.ReadLine();
                    user.Data_of_bithday = bith;
                    Console.Write("email:");
                    user.Email = Console.ReadLine();
                    Console.Write("Phone: ");
                    user.PhoneNumber = Console.ReadLine();
                    user.created_at = DateTime.UtcNow;
                    Console.Write("User name: ");
                    user.UserName = Console.ReadLine();
                password1:
                    Console.Write("Create password: ");
                    string password1 = Console.ReadLine();
                    Console.Write("re-password: ");
                    string password2 = Console.ReadLine();
                    if (password1 != password2)
                    {
                        Console.WriteLine("Password not equal");
                        goto password1;
                    }
                    else if (password2 == password1)
                    {
                        user.Password = password2;
                    }

                    await userservise.CreatAsync(user);

                }
                else if (number == "2")
                {
                    goto main;
                }
            }*/
            return null;
        }
    }
}
