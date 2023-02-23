using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShop.Servises.Helper
{
    public class Response<TResult>
    {
        public int StatusCode { get; set; } = 404;
        public string Message { get; set; } = "Not Found";
        public TResult Result { get; set; }
    }
}
