

using FashionShop.Presesation.LoginPage;

namespace ECommerce.Presentation
{
    class Program
    {
        //private static IOrderService orderService = new OrderService();
        private static async Task Main(string[] args)
        {
            while (true)
            {
                var login = new LoginPage();
                var currentUser = await login.Loginpage();
                Console.ReadKey();

            }
        }
    }
}