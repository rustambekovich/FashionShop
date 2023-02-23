

using FashionShop.Presesation.LoginPage;

namespace FashionShop.Presentation
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            var login = new Test();
/*            var currentUser = await login.TestUser();
*/            var tes = await login.TestProduct();
            Console.ReadKey();
        }
    }
}