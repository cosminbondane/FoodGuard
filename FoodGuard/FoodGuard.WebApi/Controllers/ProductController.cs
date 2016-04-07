using FoodGuard.WebApi.Base;
using FoodGuard.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace FoodGuard.WebApi.Controllers
{
    public class ProductController : BaseFoodGuardController
    {
        [HttpGet]
        public FoodGuardResponse<ProductModel> GetDemoProduct()
        {
            ProductModel demoProduct = new ProductModel();
            return Response(demoProduct);
        }
    }
}
