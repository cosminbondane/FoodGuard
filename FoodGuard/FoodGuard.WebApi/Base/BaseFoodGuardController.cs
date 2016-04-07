using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FoodGuard.WebApi.Base
{
    public class BaseFoodGuardController : ApiController
    {
        protected FoodGuardResponse<T> Response<T>(T data)
        {
            FoodGuardResponse<T> response = new FoodGuardResponse<T>()
            {
                Data = data,
                Success = true
            };

            return response;
        }
    }
}
