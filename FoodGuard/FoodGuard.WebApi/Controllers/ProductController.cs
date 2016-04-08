using FoodGuard.Business;
using FoodGuard.DAL.Entities;
using FoodGuard.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace FoodGuard.WebApi.Controllers
{
    public class ProductController : BaseFoodGuardController
    {
        protected ProductBusiness ProductBusiness { get; } = new ProductBusiness();

        [HttpGet]
        public FoodGuardResponse<IEnumerable<Product>> GetProducts()
        {
            try
            {
                return Response(ProductBusiness.GetAllProducts());
            }
            catch (Exception ex)
            {
                return HandleException<IEnumerable<Product>>(ex);
            }
        }

        [HttpGet]
        public FoodGuardResponse<List<ProductProdType>> GetProductsByTypeId(int typeId)
        {
            try
            {
                return Response(ProductBusiness.GetProductsByTypeId(typeId));
            }
            catch (Exception ex)
            {
                return HandleException<List<ProductProdType>>(ex);
            }
        }
    }
}
