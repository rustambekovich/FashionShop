using FashionShop.Domin.Common;
using FashionShop.Domin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Domin.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Data_of_bithday { get; set; }
        public string PhoneNumber { get; set; }
        public Gender genter_type { get; set; }
        public UserRole Role { get; set; }
    }
}
