using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Domin.Common
{
    public class Auditable
    {
        public long Id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set;}
    }
}
