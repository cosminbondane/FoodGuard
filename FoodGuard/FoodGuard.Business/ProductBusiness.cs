using FoodGuard.DAL.Entities;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System.Collections.Generic;

namespace FoodGuard.Business
{
    public class ProductBusiness
    {
        BaseDapperRepository<Product> ProductRepository = DependencyServiceInjection.Resolve<BaseDapperRepository<Product>>();


        public IEnumerable<Product> GetAllProducts()
        {
            return ProductRepository.GetAll();
        }
    }
}
