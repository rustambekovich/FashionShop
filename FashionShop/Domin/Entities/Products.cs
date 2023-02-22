using FashionShop.Domin.Common;
using FashionShop.Domin.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Domin.Entities
{
    public class Product : Auditable
    {
        public string Name { get; set; }
        public string description { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public ProductCatigory Clothes { get; set; } 
        public Season Season_type { get; set; }

    }
}
