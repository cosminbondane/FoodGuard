using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.WebApi.Base
{
    public abstract class BaseResponse<T, U>
    {
        public T Data { get; set; }
        public string ExceptionMessage { get; set; }
        public string Message { get; set; }
        public U Status { get; set; }
        public bool Success { get; set; }
    }
}
